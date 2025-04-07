# Portals

A Unity-based 3D puzzle game inspired by Portal, focusing on teleportation mechanics and spatial puzzles.

![Portals Screenshot](screenshots/screenshot.png)

## Description

Portals is a first-person puzzle game where players solve challenges by creating portals for teleportation between different areas. The game features:

- Portal mechanics that allow seamless teleportation between two locations
- Physics-based puzzles that require creative thinking
- Objects that maintain momentum through portals
- Multiple puzzle chambers with increasing difficulty

This project was created as part of CS50's Game Development course, demonstrating advanced concepts in 3D game development.

## How to Play

### Controls
- WASD: Movement
- Mouse: Look around
- Left-click: Place entrance portal
- Right-click: Place exit portal
- E: Interact with objects
- Space: Jump

### Objective
Navigate through the test chambers by solving puzzles using the portal gun to create pathways between otherwise disconnected areas.

## Development

### Built With
- Unity Engine
- C# for game logic and mechanics
- Unity's physics system for momentum preservation

### Project Structure
- `Assets/Scripts/` - Contains all C# scripts including portal mechanics
- `Assets/Prefabs/` - Reusable game objects like portals and interactive elements
- `Assets/Materials/` - Materials for portal effects and environment
- `Assets/Scenes/` - Different game scenes and test chambers

## Installation and Setup

1. Clone the repository
2. Open the project in Unity (version 2019.x or later recommended)
3. Open the scene `Assets/Scenes/MainMenu.unity` to start from the beginning

## Demo

[Watch the gameplay demo](https://www.youtube.com/watch?v=wftNRio_PEk)

## Features

- **Portal System**: Create entrance and exit portals on compatible surfaces
- **Physics Preservation**: Objects maintain velocity and momentum when passing through portals
- **First-Person Controller**: Smooth movement and camera controls
- **Puzzle Elements**: Pressure plates, cubes, and other interactive elements
- **Progressive Difficulty**: Chambers that gradually introduce new concepts

## Credits

- Developed by Ethan Perello
- Created as part of CS50's Game Development course
