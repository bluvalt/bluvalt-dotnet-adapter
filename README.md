# bluvalt-dotnet-adapter
A C# implementation of Bluvalt Delivery Platform Standard to use as starting point for services integration

# bluvalt-dotnet-adapter
A C# implementation of Bluvalt Delivery Platform Standard to use as starting point for services integration

# Integrate a .NET application with Bluvalt

The application have two parts 
### Authentication 
Provides Open ID Connect SSO for User Id against Bluvalt Connect. Bluvalt_SPA 4.0 is using ServiceModel (Rest API) for Event Listener and used WEB API (HttpWebRequest,HttpWebResponse) for Open Id Connect Authentication.
### Bluvalt Event Listener 
Event handler that listens and understands events coming from Bluvalt. The handler will create c# classes based on Event type and made it available in the application for further processing.


## How To Run This Application

Getting started is simple!  To run this you will need:
- Visual Studio 2015

To get started developers are expecting to have experience with the following technologies.
- Understanding of the C# programming language.
- Understating of JSON.
- Worked with .NET MVC and WEB API

### Configure the Application about the Registered service information on Bluvalt

1. Open the solution in Visual Studio 2015.
2. Open the `web.config` file.
3. Find the app key `ida:Authority` and replace the value https://dev-sso.stcs.com.sa/connect. 
4. Find the app key `ida:ClientId` and replace the value with the Client ID from Bluvalt.
4. Find the app key `ida:ClientSecret` and replace the value with the Client Secret from Bluvalt.
5. Find the app key `ida:RedirectUrl" and replace the value with the new base URL of the running applcation e.g https://localhost:44320.

### Step 5:  Run the Application

Clean the solution, rebuild the solution, and run it.

Click the sign-in link on the homepage of the application to sign-in.  On the Bluvalt Connect sign-in page, enter the name and password of a user account.


## About The Code
