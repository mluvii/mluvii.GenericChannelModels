# mluvii Generic Channel Models
## Usage
Include this repository as a submodule in your source tree and reference the csproj from your main project.

To add this repository as a submodule, execute following command in directory of your choice inside your source tree:

``
git submodule add git@github.com:mluvii/mluvii.GenericChannelModels.git
``

## Integration

Communication between mluvii and generic channel implementation is as follows:

### Initial registration

```mermaid
sequenceDiagram
    participant GenericChannelImplementation
    participant mluvii

    mluvii ->> mluvii: register generic channel
    mluvii ->> +GenericChannelImplementation: POST /webhook GenericChannelWebhookRegistrationModel
    GenericChannelImplementation ->> GenericChannelImplementation: save(webhookUrl, webhookHeaders)
    GenericChannelImplementation -->> -mluvii: HTTP 2XX
```

### Chat

```mermaid
sequenceDiagram
    actor Client
    participant GenericChannelImplementation
    participant mluvii
    actor Agent

    note over Client,Agent: Client's message
    loop buffering (optional)
    Client ->> GenericChannelImplementation: text message
    activate GenericChannelImplementation
    GenericChannelImplementation -->> Client: sent
    end
    GenericChannelImplementation ->> mluvii: POST {{ webhookUrl }} GenericChannelWebhookPayload
    activate mluvii
    note over GenericChannelImplementation,mluvii: request contains {{ webhookHeaders }}
    mluvii -->> GenericChannelImplementation: HTTP 204
    deactivate GenericChannelImplementation
    loop buffered messages (optional)
    mluvii ->> Agent: client's message
    end
    deactivate mluvii
    note over Client,Agent: Agent's reply
    Agent ->> mluvii: reply
    activate mluvii
    mluvii ->> GenericChannelImplementation: POST /activity GenericChannelActivity
    activate GenericChannelImplementation
    GenericChannelImplementation -->> mluvii: HTTP 200 GenericChannelActivityResponse
    deactivate mluvii
    GenericChannelImplementation ->> Client: message
    deactivate GenericChannelImplementation
```

## Serialization
### Enumerations
All enumerations must be sent as strings. Special value UNKNOWN must be avoided as it is only used for deserialization.

Enumerations may change by adding new values to them.
Api consumers should ignore unknown values when deserializing and translate these unknown values using UNKNOWN special value that is present in all enumerations.

## Development
The master branch contains production code deployed on app.mluvii.com. Changes about to be released in near future are merged into a branch named after the future version number (2.XX). After such future version gets deployed on production, the corresponding branch is merged into master.
