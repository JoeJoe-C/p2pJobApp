# ReadMe

This application is a peer to peer application for my second distributed computing assignment for part C where it is an individual submission. In contrast part b and part a are done in groups.

## Overview

The application showcases a peer to peer application the summary of the idea is as of follows the client side communicates to the business layer which is an API endpoint to the data layer which stores the IP addresses of active clients.
Each client will host its own server in which other clients can connect to by fetching from available client IPs via the API endpoints.
Each client can post a job (which is a python script) to its own server in which other clients when connected can process the jobs via a python scripting engine.
After a job is completed by a client, it will post the job results (result of the python script) to the data layer via the API.

## Tools & Frameworks

- NewtonSoftJson to parse API endpoints JSON responses
- .NET Core
- ServiceHost for internal client hosting

## How to run

1. Pull the repo
2. In the command line use:

`dotnet build`
`dotnet run`

3. To run multiple instances use `dotnet run` on a separate console (each client will have a randomised IP upon instantiation)

## Lessons Learnt

- Approach this problem in a design centric fashion, start with an overacrching UML diagram to showcase relations
- Understand how the separate layers such as presentation, business and data layer are done
- Implement proper testing when doing features side by side for confidence!
