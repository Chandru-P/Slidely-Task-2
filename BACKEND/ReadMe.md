# Task Name
Slidely Form App

This project is a desktop application that replicates the basic functionality of Google Forms. It allows users to create new form submissions and view existing submissions. The project is built using Visual Basic for the desktop application and TypeScript with Express for the backend. The backend server uses a JSON file to store form submissions.

Features
Desktop Application
Main Form: The main form has two buttons - "View Submissions" and "Create New Submission".
Create New Submission: Opens a form with editable fields for Name, Email, Phone Number, and a GitHub repository link. It includes a stopwatch that can be paused and resumed, and a submit button to send the form data to the backend.
View Submissions: Opens a form to view existing submissions. It includes "Previous" and "Next" buttons to navigate through the submissions.
Backend Server
/ping: A GET request that always returns True to check server status.
/submit: A POST request to submit form data. It accepts name, email, phone, github_link, and stopwatch_time as parameters.
/read: A GET request with a query parameter index to retrieve the (index+1)th form submission from the JSON file.

# Installation

1. Clone the repository.
2. Install dependencies using `npm install`.
3. Start the server using `ts-node server.ts`.

## Usage

Usage
Creating a New Submission
Open the Desktop Application: Start the desktop application by running the executable file.

Create New Submission:

Click on the "Create New Submission" button on the main form.
A new form will open with fields for Name, Email, Phone Number, and GitHub repository link.
Fill in the required details:
Name: Enter the name of the submitter.
Email: Enter the email address.
Phone Number: Enter the phone number.
GitHub Link: Enter the link to the GitHub repository.
Use the stopwatch button to start, pause, and resume the stopwatch. The stopwatch does not reset when paused.
Click the "Submit" button to submit the details to the backend server.
Example:

Open the application and click "Create New Submission".
Fill in the fields with the following data:
Name: chandru P
Email: chandru@example.com
Phone Number: 1234567890
GitHub Link: 

Use the stopwatch to record time spent on an activity.
Click "Submit".
The data will be sent to the backend server and stored in the db.json file.

Viewing Submissions
Open the Desktop Application: Start the desktop application by running the executable file.

View Submissions:

Click on the "View Submissions" button on the main form.
A new form will open, showing the details of the first submission by default.
Use the "Previous" and "Next" buttons to navigate through the submissions one by one.
Example:

Open the application and click "View Submissions".
The first submission will be displayed.
Click "Next" to view the next submission.
Click "Previous" to go back to the previous submission.

## API Endpoints

- `/ping` - GET request to check server status.
- `/submit` - POST request to submit form data.
- `/read?index={index}` - GET request to retrieve form submissions.

You can also interact with the backend server directly using API endpoints.

Check Server Status:

Endpoint: /ping
Method: GET
Response: True
Submit Form Data:

Endpoint: /submit
Method: POST
Request Body: JSON object with fields name, email, phone, github_link, and stopwatch_time


Retrieve Form Submissions:

Endpoint: /read
Method: GET
Query Parameter: index (0-based index of the submission)
Response: JSON object with the submission details

## Configuration

Environment Variables
For this project, there are no mandatory environment variables required for basic functionality. However, if you would like to customize certain aspects of the project or run the server on a different port, you can set environment variables as follows:

PORT: Specifies the port on which the backend server will run. If not set, the default port 5000 will be used.

Database Configuration
The backend server uses a JSON file (db.json) as the database to store form submissions. By default, the file is expected to be in the root directory of the project.

DB_FILE: Specifies the JSON file used as the database. By default, it is set to db.json.

Running the Server
To run the server with the configured environment variables:

Start the backend server: npx ts-node server.ts


## License

This project is licensed under the [MIT License](LICENSE).
