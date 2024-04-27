# C#-Final-Project

This project is a simple inventory management system implemented in C# using WPF (Windows Presentation Foundation). It allows users to add, remove, save, and load inventory items. The inventory data is stored in a JSON file format.

## Features

- **Add Item:** Users can add new parts to the inventory by entering the name, number, cost, and quantity.
- **Remove Item:** Items can be removed from the inventory by specifying the item number.
- **Save Data:** Inventory data can be saved to a JSON file.
- **Load Data:** Previously saved inventory data can be loaded into the application.

## Getting Started

### Prerequisites

- .NET Framework
- Visual Studio (or any compatible C# IDE)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Rutvik-Gandhi/C-Final-Project.git

Open in Visual Studio:

Navigate to the cloned directory.
Double-click on the solution file (8809972_FinalExam.sln) to open it in Visual Studio.
Build and Run:

Build the solution by pressing Ctrl + Shift + B or by selecting Build > Build Solution from the menu.
Start the application by pressing F5 or by selecting Debug > Start Debugging from the menu.
Usage
Add Items:

Enter the name, number, cost, and quantity of the item in the respective text fields.
Click the "Add" button to add the item to the inventory.
Remove Items:

Enter the number of the item you want to remove in the "Number" text field.
Click the "Remove" button to remove the item from the inventory.
Save Data:

Click the "Save" button to save the current inventory data to a JSON file.
Load Data:

Click the "Load" button to load previously saved inventory data from a JSON file.
Notes
Ensure that the text fields are filled correctly before performing any action to prevent errors.
Error handling is implemented for empty fields when adding items.

