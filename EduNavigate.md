# EduNavigate
## Formalised Idea
- Career pathway-type app that visually guides you through to where you want to go - education pathways finder
    - Inspired by poor career planners and the lack of visibility in pathways 
- Integrate AI databases with data on courses e.g.:
    - cost 
    - duration
    - flexibility
    - location
    - contents 
    - practicality 
    - employability
    - ranking
    - popularity
- Weight Criteria using filters, and then apply A* to solve for the optimal path, or potentially topological sort
- Consider the final two years of highschool diploma, which factors in:
    - International students
    - mature age students
- The aim is to have Melbourne University as the first client:
    - I am using my experiences as an engineering student here - I understand the difficulty of finding information around this path
    - We plan to then later implement a system where other unis can add in their data so that we can factor their courses in
## Technical Implementation
- Azure
    - Azure Cognitive Services:
        - Use the Text Analytics API for sentiment analysis on reviews or comments about courses and education providers
        - Apply the Language Understanding (LUIS) service to extract key information from user inputs, helping you understand their preference
    - Azure Machine Learning:
        - Train a machine learning model to provide personalized recommendations based on user preferences and historical data
    - Azure Databases:
        - Depending on the complexity of your data, consider Azure SQL Database for structured data or Azure Cosmos DB for more flexible data models

## Current Progress/Steps  
1. Design and create models for user preferences and career recommendations - start simply with engineering at Melbourne, add in a few simple variations -> create a UML diagram with a map of what I will need to start (started)
2. Implement the logic to process user input and generate career pathways
3. Store nodes in a linked list
4. Write up some sort of contract with Razali
5. ~~Create an SQL database~~
6. Develop a User interface
7. Use user authentication, profile setup
8. Write unit tests

## Implementation Details
- Classes:
    - User
    - Pathway
    - Course
- Services:
    - PathwayService - get Pathway based on input
- Set up API endpoints using controllers to handle incoming HTTP requests
    - Create a PathwayController with actions like GetPathwaysByQualification

## Notes
- Could use Topological Sort to output paths
- ~~Use visual studio~~ - should be ok for now
- Could go through innovateEd - apply end of July next year
    - Unimelb StartUp - Opens in Feb
    - Velocity/accelerator Program
- Could integrate with unimelb course planner
- Ways of using Azure:
    - Text Analytics - used to parse in course data and structure it into nodes
    - LUIS (Language Understanding) - Build an AI chatbot that allows students to form a conversation so they can pick what they want, ask questions
    - Azure Machine learning - determine courses based on interests, qualifications, career goals
        - Read trends from quantitative data e.g. most well rated courses
    - Azure SQL database - store and manage course data
    - Azure Data Factory - generate and process data from different sources
    - Azure Functions - used to respond to requests immediately
    - Azure logic apps - used to perform event-driven tasks e.g. notify students when new courses become available
- Could train a GPT for the model - use several
    - train a GPT model on the unimelb handbook

## Intended Functionality
- "Welcome Page" - users are prompted to select if they are a student, or a university representative
### Potential Student
1. "Student Input" - A Student seeking tertiary education at unimelb (highschool leaver, mature age student, international student) inputs desired qualification e.g. degree that they want, and the qualification they have e.g. finished year 10
    - Students may make an account to save their data and be notified if relevant pathway or course data is added
2. "Preferncing" - They are then prompted to enter a set of preferences that will help to differentiate between the potential pathways to that qualification and to determine what will work best for them
    - They can (put in preference values e.g. a certain desired duration, maximum price etc. and) order their preferences e.g. ranking their importance on cost, duration etc.
3. "Pathways Display" - Once preferences are entered, a visualisation of the pathways to their desired qualification is output, each is ranked based on their input (and unspecified criteria) and displayed
    - Each pathway segment is given a name and short description when selected, and users may go through each fork along the pathway road and examine the potential options, with a comparison given
    - Each pathway appears as a potentially inter-linked set of bubbles, where each bubble represents a sub-course i.e. Year 12, and a student may select a specific bubble to obtain key information such as the required year 12 subjects in this subpath
    - (Potentially) an AI chatbot is present under all parts of the display screen, shown first explaining the different pathways, and then able to answer questions when prompted about the specifics of each pathway and further details
    - A user may select subpaths etc. of the destination pathway until one has been selected that entirely maps their journey to the qualification, and save it under their selection (they may continue to select multiple and save them)
4. "Pathway Selection" - Once (a) destination pathway(s) are selected, the user can see a mock-"Pathways Display" screen with only what they have selected, where they can see links and information to further decide between pathways (and ask the chatbot questions), this screen can be saved to and returned to in their profile

### University Representative
1. "Selection Screen" - A uni rep must choose what uni they are from, get verification through login, and then see (and edit) information stored about their uni
2. "Course Information" - A rep can use a fast template to add in information about a new course or subject, as well as input a course document (like the university handbook), which can be scanned for information (and used to train the AI chatbot)
    - Scanned information may be verified before entered by the uni rep if needed
3. "Uni Map Display" - A node-like map (like an obsidian map) can be viewed for the pathways within the uni, and new nodes or nodes with new data added can be displayed in green
    - A user can also drill down into different pathways and view their uni's information or edit it if neccessary