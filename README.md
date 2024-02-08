DataTemplator.Api

Build Instructions

Prerequisites:
Ensure that you have the following prerequisites installed on your development machine:
- .NET Core SDK - The application is built using .NET Core.
- Docker - Docker is required for containerization.

Build the Application Locally:
1. Clone the repository to your local machine:
   git clone https://github.com/brochelito/MANAYON_20240208.git
2. Navigate to the project directory:
   cd MANAYON_20240208
3. Build the application using the .NET CLI:
   dotnet build -c Release

Build the Docker Image:
1. Build the Docker image using the provided Dockerfile. In the project directory, run:
   docker build -t datatemplatorapi .
2. Verify the Docker Image. To verify that the Docker image has been created successfully, list the Docker images:
   docker images

Run Instructions:
Now that the application is built and the Docker image is created, you can run the application in a Docker container.
1. Run the Docker container:
   docker run -p 8080:80 --name datatemplator-container datatemplatorapi
2. Access the application in a web browser or a tool like Postman:
   http://localhost:8080/api/data
