# Distributed Calculator

The Distributed Calculator is a project designed to explore the concepts of distributed systems and cloud-native applications. It consists of five microservices, each responsible for one arithmetic operation (addition, subtraction, multiplication, division), and a client application for the user interface.

## Architecture

Each service is a separate ASP.NET application, and they communicate with each other and the client application using Dapr's service invocation and pub/sub capabilities.

## Services

- **Addition Service**: This service handles addition operations.
- **Subtraction Service**: This service handles subtraction operations.
- **Multiplication Service**: This service handles multiplication operations.
- **Division Service**: This service handles division operations.
- **History Service**: This service handles caching and database operations. It stores the result of each calculation in a Redis database and caches the last 10 calculations.

## Technologies

- **Dapr**: An event-driven, portable runtime for building microservices.
- **ASP.NET Core**: A cross-platform framework for building modern cloud-based web applications.
- **RabbitMQ**: An open-source message broker.
- **Redis**: An open-source, in-memory data structure store, used as a database and cache.
- **Docker**: A platform for developing, shipping, and running applications inside containers.

## Getting Started

1. Install the required software: Docker, Dapr CLI, RabbitMQ, Git, and a lightweight database of your choice.
2. Clone the Git repository.
3. Build and run each service with Dapr using the `dapr run` command.
4. Test the services by sending HTTP requests to the Dapr sidecar.

## Contributing

Contributions are welcome! Please read the contributing guide for details on how to contribute to this project.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
