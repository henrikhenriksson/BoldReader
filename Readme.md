# ADHD Reader C\# edition

By: Henrik Henriksson	

### **Project Goals**

1. **What is the primary purpose of the application?**  
   * The application's main purpose is to create an accessible GUI free from flashy distractions that will be used to upload and extract text from documents like .pdf to start with.  
   * The application will then iterate through each word in the extracted text and highlight by boldening the first 2 and last 2 letters of each word. In case the word contains 4 characters or less, only the first and last letters will be bolded.  
   * The application will also have “save to pdf” functionality.  
2. **Who is the target audience?**  
   * The main audience for this project is neuroatypical people with ADHD. The reasoning behind the application is that it is easier for neuroatypical people to “take in the whole word” at a glance when the first few and last few letters in each word are bolder than the rest of the word.  
3. **Are there any specific features you already have in mind?**  
   * Load a document into the application.  
   * Extract the main text of the document while ignoring things such as headers or image descriptions.  
   * Save the highlighted document as a new .pdf

### **Technical Requirements**

4. **Will the application interact with a database?**  
   * In the first phase of the applications development, no database will be needed. In the future, saving text to a database might become relevant.  
5. **Do you need any third-party libraries or APIs?**  
   * To start with, the application will be standalone. One need that could arise is the use of a third party .pdf text extractor.  
   * Third party library that might be needed would be .pdf text extractor, or .pdf document creator classes.  
6. **What is your experience level with Windows Forms?**  
   * This is my first Windows Forms application, i have edited such applications in the past and have a grasp of the concept.

### 

### **Design and User Interface**

7. **Do you have any specific design requirements or preferences?**  
   * The color scheme should be calm and restive as the purpose of the app is to facilitate reading text.  
8. **How many forms do you anticipate needing in the application?**  
   * To start with, one main form for the GUI. Preferably, all interactions with the application will be with the main GUI. The Gui should contain buttons for opening and saving the document, as well as one to start the conversion”. The main form should contain a container that presents the text to the reader after the conversion is done.

### **Development and Deployment**

9. **Do you have a timeline or deadline for the project?**  
   * There is no specific deadline for this task. I would like it completed as soon as possible, with further iterations of the application to come.  
10. **Will the application need to be deployed on multiple platforms or just Windows?**  
    * In the first development phase, Windows is the main platform. Later on, if time allows, the app should be able to run on Linux and Mac.

### **Next Steps**

Once we have more details, we can move on to the following steps:

1. **Defining the Project Structure:**  
   * Identify classes, interfaces, and project organization.  
2. **Setting Up a Development Plan:**  
   * Outline a plan for development, including milestones and deliverables.  
3. **Identifying Learning Resources:**  
   * I can suggest tutorials, documentation, and books based on your specific needs.  
4. **Creating a Prototype or Wireframe:**  
   * Sketching out the UI and creating a basic prototype can help visualize the application.

