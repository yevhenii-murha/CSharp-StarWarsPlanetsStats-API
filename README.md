# CSharp-StarWarsPlanetsStats-API

## Overview

The Star Wars Planets Stats API is a C# application that fetches data about Star Wars planets from an external API and provides statistical analysis of their properties. The program displays statistics such as the maximum and minimum values for properties like population, diameter, and surface water.

## Features

- Fetches planet data from the Star Wars API.
- Analyzes and displays statistics for planet properties.
- Provides user interaction to choose the type of statistics.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later).

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/StarWarsPlanetsStats_API.git
   ```

2. Navigate to the project directory:

   ```bash
   cd StarWarsPlanetsStats_API
   ```

3. Restore the project dependencies:

   ```bash
   dotnet restore
   ```

4. Build the project:

   ```bash
   dotnet build
   ```

### Running the Application

To run the application, use the following command:

```bash
dotnet run
```

Follow the on-screen prompts to choose the type of statistics you want to see.

## Usage

1. The application will fetch planet data from the [Star Wars API](https://swapi.dev/).
2. It will display the properties of each planet.
3. You can then choose which property's statistics (population, diameter, surface water) you wish to analyze.

## Acknowledgments

- [Star Wars API](https://swapi.dev/) for providing the planet data.
