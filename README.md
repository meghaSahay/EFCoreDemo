This is a sample application based on clean architecture. The code is divided into three projects namely 

- SocialNetworkingAPI as starter project containing controller code.
- Domain project containg code for entity.
- Persistence containing code for database migrations.
  
1. This code is an end to end working web api. The application is SocialNetworkingAPI where I have made User as an entity.
2. The User table is created in the SQLite database using Entity core framework.
3. Data is inserted using Seed class when application loads.
4. Then the user entity can be retrieved though rest enpoint using GetUsers() and GetUser(id) action methods in controller.

   
The detailed explaination of code is available in my linkedin article https://www.linkedin.com/pulse/implementing-orm-net-megha-sahay-chrhc
