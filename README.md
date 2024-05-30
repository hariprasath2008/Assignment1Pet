# Virtual Pet Simulator

## Overview
This is a simple C# application that allows users to take care of a virtual pet, choosing among a cat, dog, or rabbit. The user can perform various actions to maintain their pet's wellbeing, ensuring it remains happy and healthy.

### Explanation Video
For a demonstration of the Virtual Pet Application, please watch [this video](https://youtu.be/0bppzY0XGns?si=PVVX-ZwbSMwwO5n6).

## Detailed Project Features

### 1. Pet Creation
- Users can choose a pet type (cat, dog, rabbit) and name their pet.
- A welcome message will be displayed, including the pet's type and name.

### 2. Pet Care Actions
- **Feeding**: Decreases hunger and slightly increases health.
- **Playing**: Increases happiness and slightly increases hunger.
- **Resting**: Improves health and slightly decreases happiness.
- Each action modifies the pet's stats accordingly and displays a message describing the action's effect.

### 3. Pet Status Monitoring
- The pet’s stats are tracked and displayed, including hunger, happiness, and health, each on a scale of 1 to 10.
- A status check is implemented to warn the user if any stat is critically low or high.

### 4. Time-Based Changes
- The application simulates the passage of time, with each action representing the passing of an hour.
- Hunger increases over time, and happiness decreases slightly, prompting regular interaction from the user.

### 5. Enhanced Interaction Logic
- If the pet is neglected, there are consequences, such as health deterioration if the pet is too hungry or unhappy.
- Special messages or events are included based on the pet's status (e.g., the pet refusing to play if it is too hungry).

## Installation and Setup
1. Clone the repository.
2. Open the solution in your preferred C# IDE (e.g., Visual Studio).
3. Build the solution.
4. Run the application.

## Usage
1. Start the application.
2. Choose your pet type and give it a name.
3. Use the available actions (Feeding, Playing, Resting) to take care of your pet.
4. Monitor your pet's stats and ensure none of them reach critically low or high levels.
5. Interact with your pet regularly to maintain its wellbeing.

Enjoy taking care of your virtual pet!

---

For more information, please refer to the video demonstration linked above.
