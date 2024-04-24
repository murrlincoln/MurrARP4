# Vanderbilt AR Campus Explorer
Demo Link: https://www.loom.com/share/57d0b80a3fec42ee88ec7b49852c754c?sid=a98757f7-32f0-42f3-bbbd-c6896c4d8011 
## Introduction
The Vanderbilt AR Campus Explorer is an augmented reality (AR) application designed to provide prospective students, their families, and curious current students with a novel and interactive tour of Vanderbilt University's campus. By overlaying digital content on real-world objects, the app offers an engaging way to learn fun facts and relevant information about Vanderbilt's campus's buildings, statues, and faces.
## Goal
The primary goal of this project is to create a unique and immersive AR experience that allows users to explore the campus and discover interesting and relevant information about its various landmarks. By incorporating AR technology, the application aims to make the campus tour more engaging, informative, and accessible to a wider audience without needing a tour guide.
## Design and Development Process
The Unity game engine and Vuforia SDK for AR applications were employed to make this explorer. The development process began with collecting images of different buildings and markers around campus for use as image targets and testing them to ensure their suitability for use in various conditions and times of day. This was an iterative process and resulted in me taking multiple images and learning the distinctive features of given targets and objects. 
Once the image targets were established, relevant facts and features were added to each target using information from Vanderbilt's official website. To enhance user engagement, a script was written to allow users to click on the image target and be directed to a link or website for additional information. However, this feature was not implemented for all objects, as some did not have additional information to share.
To further improve user experience, a voice-to-audio AI tool was used to create audio-guided material that automatically plays when a user points their camera at certain objects. A positive feedback noise was added to indicate when an image is being successfully tracked. Given the tool's free trial, I added descriptions to nearly a dozen objects but could not add it for everything. I wrote a script to auto-play the audio when the image begins tracking.
## How to Use
Follow these steps to set up and use the AR Browser for Vanderbilt Campus:

- Download and install Unity Hub on your computer. Go through the setup process to ensure it is properly installed.
- Clone this repository to your local machine
- Open Unity Hub and click on the "Add" button. Then, choose "Add Project from Disk" and select the cloned project directory.
- Wait for Unity to initialize the project and install the necessary packages. This may take a few moments.
- Once the project is loaded, navigate to the Scenes folder by clicking on File -> Open Scene -> Scenes Folder -> SampleScene.unity.
- With the SampleScene open, click on the play button located at the top of the Unity editor to run the AR application.
- If prompted, grant the necessary permissions for the application to access your device's camera and location services.
- Point your device's camera at the Vanderbilt campus and surrounding area. The AR browser will recognize specific images, such as building facades or landmarks, and display relevant information, bus routes, and interactive features.
- Explore the campus using the AR browser, and interact with the digital content overlaid on the real-world environment. Use the maintenance call buttons or other features provided on a per-building basis, as needed.
- To exit the AR browser, simply close the application or press the designated exit button within the app.

Note: Ensure that your device meets the minimum requirements for running the AR application, including support for AR capabilities and the necessary sensors (camera, GPS, etc.).
