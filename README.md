# ChatZilla

Group of friends project for real-time chat application.

---

## How to run the app

Requirements:

- dotnet version: **8.0.10**
- npm version: **20.11.0**

1. Clone repo
2. Open chatApp.client folder
3. Run `npm install`
   1. If there is a problem running `npm install`. Then try running `npm install --legacy-peer-deps`
4. Navigate to src/ directory and run `npm run dev` to run the front end project
5. Create postgreSql database with these parameters:
   1. name `ChatZilla`
   2. password `1234`
   3. ports `5432`
6. Create MongoDb database called `ChatApp`.
7. Run `dotnet ef database update`
8. Run `DummyData.sql` script in your database to check if everything is correct and have dummy data to work with.

## Conventional Commits

The following commit types are used:

- **fix**: A bug fix
- **feat**: A new feature
- **BREAKING CHANGE**: A breaking change

### Examples

- **feat**: Add a new login page
