# Simple Web Browser

## Overview
This project is a simple web browser developed using **C# and .Net**. It provides a user-friendly interface with features such as webpage retrieval, navigation history, and favorites management. 

## Features
- **Basic Web Browsing**: Enter a URL and load the corresponding webpage.
- **Display Webpage Information**: Shows the HTML content, status code, and title of the page.
- **Navigation Controls**: 
  - Back and forward navigation.
  - Reloading the current page.
- **Homepage Customization**: Users can modify and set a custom homepage.
- **Favorites Management**:
  - Add, modify, and delete favorite URLs.
  - Associate names with favorite URLs.
  - Retrieve favorite pages by double-clicking their names.
- **History Management**:
  - Maintain a list of visited URLs.
  - Load previously visited pages.
  - Delete individual or all history records.

## Technologies Used
- **Programming Language**: C#
- **IDE**: Visual Studio
- **Libraries**:
  - `System.IO` - File handling
  - `System.Net` - HTTP requests
  - `System.Windows.Forms` - GUI elements

## Installation & Setup
1. Clone this repository:
   ```sh
   git clone https://github.com/yourusername/simple-web-browser.git
   ```
2. Open the project in **Visual Studio**.
3. Build and run the project.

## Usage Guide
### Navigation
- **Home Button**: Loads the homepage.
- **Back & Forward Buttons**: Navigate through browsing history.
- **Reload Button**: Refreshes the current page.
- **Search Bar**: Enter a URL and press "Search" to load the page.

### Managing Favorites
1. Click the **Favorites** button to add the current URL.
2. View, rename, or delete favorites from the **Favorites List**.
3. Double-click a favorite to open the corresponding page.

### Viewing History
1. Click **History** to view previously visited URLs.
2. Double-click an entry to reopen the page.
3. Use "Delete" or "Clear All" to remove history records.

### Changing Homepage
1. Click **Modify Homepage** in settings.
2. Enter a new URL and save.

## Known Issues & Future Enhancements
- **Data Persistence**: Currently, favorites and history are not saved after closing the browser.
- **CSS & JavaScript Support**: Rendering is limited to HTML only; future versions may include CSS and JavaScript processing.
- **Multiple Tabs**: Adding tab support to improve multitasking.

## License
This project was developed as part of a web programming lab and is intended for educational purposes.


