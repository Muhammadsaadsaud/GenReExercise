# API Implementation

## Overview
This project implements a simple Web API using ASP.NET Core. It provides endpoints for two tasks:
1. Checking if a given ransom note can be constructed from a magazine.
2. Determining if a given binary tree is a valid binary search tree (BST).

## Prerequisites
Ensure you have the following installed:
- .NET 8 SDK
- Visual Studio 2019 or newer
- Postman for API testing

## Running the Project
1. Clone or download the project from the repository.
2. Open the API.sln solution in Visual Studio.
3. Build and run the solution by clicking the green "Play" button.

## Endpoints Testing
You can test the endpoints using Postman. Below are the details of the endpoints and how to test them:

### RansomNote Controller
- **Endpoint:** GET /RansomNote/canConstruct
  - **Parameters:**
    - ransom (string): The ransom note.
    - magazine (string): The magazine content.
  - **Example:** http://localhost:5000/RansomNote/canConstruct?ransom=aa&magazine=aba
  - **Expected Response:** `true` or `false`

### BinarySearchTree Controller
- **Endpoint:** POST /BinarySearchTree/checkNode
  - **Body:**
    ```
    {
        "value": 2,
        "left": {
            "value": 1
        },
        "right": {
            "value": 3
        }
    }
    ```
  - **Example:** http://localhost:5000/BinarySearchTree/checkNode
  - **Expected Response:** `true` or `false`

## Troubleshooting
- If you encounter NuGet package restore failures, refer to [this link](https://stackoverflow.com/questions/52400750/how-to-resolve-nuget-package-restore-failed-in-visual-studio).
- If the reference assemblies for .NETFramework,Version=v8.0 are not found, ensure you have .NET 8 SDK installed and try restarting the project.
