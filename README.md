# BookStore.API
## Notes
- Swagger UI is used when debugging the API for ease of use
- Initial db migration has been added, if the database does not yet exist on disk then it will be created upon first API call
- There are 10 sample books hard-coded into the API which can be used to seed the database by calling the `GET books/seeddata` endpoint
- If no data is seeded, the database will be empty and books will need to be added manually to be able to see any data
- The `launchSettings.json` file specifies that `https://localhost:7213` will be used when debugging (this is needed for the web solution)
- The `BookStore.Models` project has been duplicated between solutions, but in a live environment this would be a Nuget package shared between them
