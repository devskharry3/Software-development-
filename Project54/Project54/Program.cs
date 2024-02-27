using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
namespace HealthCareAppointmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStorage dataStorage = new DataStorage();
             // Intializing the system data (sample patients, doctor information and so on)
        while (true)
        {
            Console.WriteLine("Welcome the Healthcare Appointment System (HCAS) of St Micheal's Hospital");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Enter your choice");
            Console.WriteLine();
            Console.WriteLine("1. Patient login");
            Console.WriteLine("2. Doctor login");
            Console.WriteLine("3. Staff login");
            Console.WriteLine("4. Exit application");
            

         int choice = Convert.ToInt32(Console.ReadLine());

         switch (choice)
         {
            case 1:
            // Patient login logic 
            PatientUI.Login(); // UI- User Interface 
            break;
            case 2:
            // Doctor login logic 
            DoctorUI.Login(dataStorage); 
            break;
            case 3:
            // Staff login logic 
           StaffUI staffUI = new StaffUI();
          staffUI.Login();

            break;
            case 4:
            //  Existing the application 
            Console.WriteLine("Exixting HCAS application.");
            break; 
            default:
            Console.WriteLine("This is an invaild entry please select from the avaliable options only");
            break;
         }
        }
    }
    class Patient
{
   public string Firstname;
   public string Lastname;
   public string Email;
   public string Username;
   public string password;
   public string HealthCardNumber; 
   public string HealthCardExpiry;
   public string Address;
   public string PhoneNumber;

   public bool ValidatePassword(string enteredPassword)
   {
    return password == enteredPassword;
   } 


}  
    class Appointment
{
    public int AppointmentId;
    public Patient Patient;
    public Doctor Doctor;
    public Location Location;
    public DateTime DateTime;
     public AppointmentStatus Status;
     public string Result; 

     public Appointment(int appointmentId, Patient patient, Doctor doctor, Location location, DateTime dateTime, AppointmentStatus status, string result = "")
     {
        AppointmentId = appointmentId;
        Patient = patient;
        Doctor = doctor;
        Location = location;
        DateTime = dateTime;
        Status = status;
        Result = result;

     }
}

public enum AppointmentStatus
{
    Scheduled,
    Completed,
    Canceled,
    Rescheduled
} 
class Location
{
   public int LocationId;
   public string Name;
   public string Address;
   public string PhoneNumber; 
   public List<Doctor> Doctors;
   public Location(int locationId, string name, string address, string phoneNumber)
   {
    LocationId = locationId;
    Name = name;
    Address = address;
    PhoneNumber = phoneNumber;
    Doctors = new List<Doctor>(); 
   }
} 
    class Doctor
    {
        public int DoctorId;
        public string Name;
        public string Specialty; 
        public string Username; 
    private string password;
        public List<Appointment> Appointments;

        public Doctor(int doctorId, string name , string specialty, string username, string password)
        {
            DoctorId = doctorId;
            Name = name;
            Specialty = specialty;
            Username = username;
            this.password = password;
            Appointments = new List<Appointment>();
        }
        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }
        public void UpdateAppointmentResult(int appointmentId, string result)
        {
            Appointment appointmentToUpdate = Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
            if (appointmentToUpdate != null)
            {
                appointmentToUpdate.Result = result;
            }
        }
        public bool ValidatePassword(string enteredPassword)
        {
            return password == enteredPassword;
        }
    
    }

    class Inquiry
{
  public int InquiryId;
  public string Symptoms;
  public string DurationOfSymptoms;
  public string PreviousMedicalHistory;
  public string CurrentMedications;
  public string Allergies;
  public string AdditionalComments;
  public string ReasonForBooking;
  public string IllenessCategory;
  public Patient Patient;
  public Inquiry(int inquiryId, Patient patient, string symptoms, string durationOfSymptoms, string previousMedicalHistory,
  string currentMedications, string allergies, string additionalComments, string reasonForBooking, string illnessCategory)
  {
    InquiryId = inquiryId;
   Patient = patient;
    Symptoms = symptoms;
    DurationOfSymptoms = durationOfSymptoms;
    PreviousMedicalHistory = previousMedicalHistory;
    CurrentMedications = currentMedications;
    Allergies = allergies;
    AdditionalComments = additionalComments;
    ReasonForBooking = reasonForBooking;
    IllenessCategory = illnessCategory;

    
  }
}

    class DataStorage
{
    private List<Patient> patients;
    private List<Doctor> doctors;
    private List<Location> locations;
    private List<Appointment> appointments;
    private List<Inquiry> inquiries;

    public DataStorage()
    {
        // Initialize the data collections
        patients = new List<Patient>();
        doctors = new List<Doctor>();
        locations = new List<Location>();
        appointments = new List<Appointment>();
        inquiries = new List<Inquiry>();
    }

    // Properties for better encapsulation
    public List<Patient> Patients => patients;
    public List<Doctor> Doctors => doctors;
    public List<Location> Locations => locations;
    public List<Appointment> Appointments => appointments;
    public List<Inquiry> Inquiries => inquiries;

    // Patient related methods
    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    // Doctor related methods
    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public Doctor GetDoctorById(int doctorId)
    {
        return doctors.Find(doctor => doctor.DoctorId == doctorId);
    }

    // Location related methods
    public void AddLocation(Location location)
    {
        locations.Add(location);
    }

    public Location GetLocationById(int locationId)
    {
        return locations.Find(location => location.LocationId == locationId);
    }

    // Appointment related methods
    public void AddAppointment(Appointment appointment)
    {
        appointments.Add(appointment);
    }

    // Inquiry related methods
    public void AddInquiry(Inquiry inquiry)
    {
        inquiries.Add(inquiry);
    }

    // Function to get a list of appointments for a specific doctor
    public List<Appointment> GetDoctorAppointments(Doctor doctor)
{
    return appointments.Where(appointment => appointment.Doctor == doctor).ToList();
}

     public List<Doctor> GetDoctors()
 {
    return new List<Doctor>(doctors);
 }


}
//---------------------------------------------------------------------------------------------------//

class DoctorUI {
    // Inside your DoctorUI class
public static void AddNewDoctor(DataStorage dataStorage)
{
    Console.WriteLine("Adding a new doctor...");

    // Prompt the user to enter doctor details
    Console.Write("Enter Doctor's Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Doctor's Specialty: ");
    string specialty = Console.ReadLine();

    Console.Write("Enter Doctor's Username: ");
    string username = Console.ReadLine();

    Console.Write("Enter Doctor's Password: ");
    string password = Console.ReadLine();

    // Generate a unique doctor ID (You can modify this method as needed)
    int doctorId = GenerateUniqueDoctorId(dataStorage);

    // Create a new doctor object
    Doctor newDoctor = new Doctor(doctorId, name, specialty, username, password);

    // Add the new doctor to your data storage
    dataStorage.AddDoctor(newDoctor);

    Console.WriteLine("Doctor added successfully.");
}

// Helper method to generate a unique doctor ID
private static int GenerateUniqueDoctorId(DataStorage dataStorage)
{
    List<Doctor> doctors = dataStorage.GetDoctors();

    if (doctors.Count == 0)
    {
        // If there are no existing doctors, start with ID 1
        return 1;
    }
    else
    {
        // Find the highest existing doctor ID and add 1
        int maxId = doctors.Max(doctor => doctor.DoctorId);
        return maxId + 1;
    }
}


     
     
  public static void Login(DataStorage dataStorage) {
    Console.Write("Enter your username: ");
    string username = Console.ReadLine();

     Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    Doctor loggedInDoctor = Authenticate(username, password);

    if (loggedInDoctor != null) {
      Console.WriteLine($"Welcome, Dr. {loggedInDoctor.Name} ({loggedInDoctor.Specialty})");
      while (true) {
        Console.WriteLine("Doctor Menu");
        Console.WriteLine("1. View Appointments");
        Console.WriteLine("2. Update Appointment Result");
        Console.WriteLine("3. Logout");
        Console.Write("Select an option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option) {
        case 1:
          ViewAppointments(loggedInDoctor);
          break;
        case 2:
          UpdateAppointmentResult(loggedInDoctor);
          break;
        case 3:
          Console.WriteLine("Logging out...");
          return; // Exit the doctor loop
        default:
          Console.WriteLine("Invalid option. Please select a valid option.");
          break;
        }
      }
    }
    else {
      Console.WriteLine("Invalid credentials. Please try again.");
    }
  }

  public static Doctor Authenticate(string username, string password)
   {
    // Perform authentication based on username and password
    DataStorage dataStorage = new DataStorage();
    List<Doctor> doctors = dataStorage.GetDoctors();  
   
   return doctors.FirstOrDefault(doctor => doctor.Username == username && doctor.ValidatePassword(password));
  }

public static void ViewAppointments(Doctor doctor)
{

    Console.WriteLine($"Viewing Appointments for Dr. {doctor.Name}...");
    // creating instance of the class DataStorage 
    DataStorage dataStorage = new DataStorage();

    // Get the appointments associated with the logged-in doctor
    List<Appointment> doctorAppointments = dataStorage.GetDoctorAppointments(doctor);

    if (doctorAppointments.Count > 0)
    {
        Console.WriteLine("Your Appointments:");

        foreach (var appointment in doctorAppointments)
        {
            Console.WriteLine($"Appointment ID: {appointment.AppointmentId}");
            Console.WriteLine($"Patient: {appointment.Patient.Firstname} {appointment.Patient.Lastname}");
            Console.WriteLine($"Location: {appointment.Location.Name}");
            Console.WriteLine($"Appointment Date and Time: {appointment.DateTime}");
            Console.WriteLine($"Status: {appointment.Status}");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
    else
    {
        Console.WriteLine("You have no scheduled appointments.");
    }
}

//----------------------------------------------------------------------------------------------------//

public static void UpdateAppointmentResult(Doctor doctor)
{
    Console.WriteLine($"Updating Appointment Results for Dr. {doctor.Name}...");
DataStorage dataStorage = new DataStorage();
    // Get the appointments associated with the logged-in doctor

    List<Appointment> doctorAppointments = dataStorage.GetDoctorAppointments(doctor);

    if (doctorAppointments.Count > 0)
    {
        Console.Write("Enter the Appointment ID to update result: ");
        int appointmentIdToUpdate = Convert.ToInt32(Console.ReadLine());

        // Find the appointment with the specified ID
        Appointment appointmentToUpdate = doctorAppointments.FirstOrDefault(appointment => appointment.AppointmentId == appointmentIdToUpdate);

        if (appointmentToUpdate != null)
        {
            Console.Write("Enter the updated result: ");
            string updatedResult = Console.ReadLine();

            // Update the result of the appointment
            appointmentToUpdate.Result = updatedResult;

             Console.WriteLine("Appointment result updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid Appointment ID. Appointment not found.");
        }
    }
    else
    {
        Console.WriteLine("You have no scheduled appointments.");
    }
}
}
//---------------------------------------------------------------------------------------------------
// create staff member class 
class StaffMember
{
    public int StaffId;
    public string Name;
    public string Position;
    public string Email;
    public string Username;
    public string Password;

}

class StaffUI
{
    private List<StaffMember> staffMembers;

     public StaffUI()
    {
        // Initialize and populate the staffMembers list with staff member data
        staffMembers = new List<StaffMember>
        {
            new StaffMember { StaffId = 1, Name = "Pete shank", Position = "Manager", Email = "peteshank@gmail.com", Username = "damian", Password = "password1" },
            new StaffMember { StaffId = 2, Name = "jefferey  lot", Position = "Cheif Medical Director", Email = "jeffereylot@gmail.com", Username = "lot", Password = "password2" },
             new StaffMember { StaffId = 1, Name = "griff cane", Position = "Janitor", Email = "griff cane.com", Username = "griff", Password = "password3" },
              new StaffMember { StaffId = 1, Name = "Moriah steve", Position = "Surgueon", Email = "moriahsteve@gmail.com", Username = "steve", Password = "password4" },
               new StaffMember { StaffId = 1, Name = "adams xeus", Position = "Resident", Email = "adamsxeus.com", Username = "peter", Password = "password5" },
           
           
           
           
             };
    }

    public  void Login()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

       
        if (Authenticate(username, password))
        {
            Console.WriteLine("Welcome, Staff Member!");
            while (true)
            {
                Console.WriteLine("Staff Menu");
                Console.WriteLine("1. View Staff Information");
                Console.WriteLine("2. Update Staff Information");
                Console.WriteLine("3. Logout");
                Console.Write("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ViewStaffInformation();
                        break;
                    case 2:
                        UpdateStaffInformation();
                        break;
                    case 3:
                        Console.WriteLine("Logging out........");
                        return; // Exit the staff loop
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid credentials. Please try again.");
        }
    }


public bool Authenticate(string username, string password)
    {
        foreach (var staffMember in staffMembers)
        {
            if (staffMember.Username == username && staffMember.Password == password)
            {
                return true; // Authentication succeeded
            }
        }

        return false; // Authentication failed
    }
   public  void ViewStaffInformation()
{
    
    Console.WriteLine("Staff Information:");
    foreach (var staffMember in staffMembers)
    {
        Console.WriteLine($"ID: {staffMember.StaffId}");
        Console.WriteLine($"Name: {staffMember.Name}");
        Console.WriteLine($"Position: {staffMember.Position}");
        Console.WriteLine($"Email: {staffMember.Email}");
        Console.WriteLine("----------------------------");
    }
}

public  void UpdateStaffInformation()
{
  
    Console.WriteLine("Update Staff Information:");
    Console.Write("Enter the ID of the staff member to update: ");
    int staffIdToUpdate = Convert.ToInt32(Console.ReadLine());

    StaffMember staffToUpdate = staffMembers.FirstOrDefault(staffMember => staffMember.StaffId == staffIdToUpdate);
  
    if (staffToUpdate != null)
    {
        // Prompt the user for updated information
        Console.Write("Enter updated name: ");
        string updatedName = Console.ReadLine();
        Console.Write("Enter updated position: ");
        string updatedPosition = Console.ReadLine();
        Console.Write("Enter updated email: ");
        string updatedEmail = Console.ReadLine();

        // Update the staff member's information
        staffToUpdate.Name = updatedName;
        staffToUpdate.Position = updatedPosition;
        staffToUpdate.Email = updatedEmail;

        Console.WriteLine("Staff information updated successfully.");
    }
    else
    {
        Console.WriteLine("Staff member not found.");
    }
}

}
class PatientUI
{
    // List of sample patient profiles for testing
    static List<Inquiry> inquiries = new List<Inquiry>();
    static List<Patient> patients = new List<Patient>
    {
        new Patient
        {
           Firstname = "chloe", 
           Lastname = "pheelz",
           Email = "chloepheelz@gmail.com",
           Username = "chloe456",
           password = "rangist123",
           HealthCardNumber = "BC12045656",
           HealthCardExpiry = "2023-12-31",
           Address = "5 Adebowale off surulere strt",
           PhoneNumber = "08085731944"


        },
         new Patient
        {
           Firstname = "Felix", 
           Lastname = "Emmanuel",
           Email = "felixemmanuel@gmail.com",
           Username = "felix419",
           password = "adjectival321",
           HealthCardNumber = "BC12391643",
           HealthCardExpiry = "2023-12-31",
           Address = "5 adebowale off surulere street",
           PhoneNumber = "08039286695"
},
 new Patient
        {
           Firstname = "Adefaka", 
           Lastname = "Gbolahan",
           Email = "adefakagbolahan@gmail.com",
           Username = "faka210",
           password = "niche409",
           HealthCardNumber = "BC33148998",
           HealthCardExpiry = "2023-12-31",
           Address = "5 alagbka off first bank estate ",
           PhoneNumber = "08146783404"


        },
         new Patient
        {
           Firstname = "Chris", 
           Lastname = "Chigozie",
           Email = "chrischigozie@gmail.com",
           Username = "chris531",
           password = "prob764",
           HealthCardNumber = "BC45645678",
           HealthCardExpiry = "2023-11-31",
           Address = "21 adebobajo sain john and mary hospital",
           PhoneNumber = "08146783404"


        },
         new Patient
        {
           Firstname = "Damian", 
           Lastname = "Amanda",
           Email = "damianamanda@gmail.com",
           Username = "rizzy323",
           password = "gega780",
           HealthCardNumber = "BC12945678",
           HealthCardExpiry = "2023-10-31",
           Address = "12 oyarubulem near isinkan market",
           PhoneNumber = "08085731944"


        },
    };
    public static void Login()
    { 
      Console.Write("Enter your username: ");
      string username = Console.ReadLine();

      Console.Write("Enter your password: ");
      string password = Console.ReadLine();

      Patient loggedInPatient = Authenticate(username, password);
      if (loggedInPatient != null)
      {
        Console.WriteLine($"Welcome, {loggedInPatient.Firstname}  {loggedInPatient.Lastname}");
        DataStorage dataStorage = new DataStorage();
        List<Appointment> appointments = new List<Appointment>();

        while (true)
        {
            Console.WriteLine("Patient Menu");
            Console.WriteLine("1. Schedule Appointment");
            Console.WriteLine("2. view Appointments");
            Console.WriteLine("3. Update Information");
            Console.WriteLine("4. Sumbit Inquiry");
            Console.WriteLine("5. Logout");
            Console.WriteLine("Select an option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: 
    // Implement appointment scheduling logic 
    ScheduleAppointment(loggedInPatient, dataStorage, appointments);
    break;

                case 2:
                // Implement appointment viewing logic 
                ViewAppointments(loggedInPatient, appointments);
                break;
                case 3: 
                // Implement updating contact information logic 
                UpdateContactInformation(loggedInPatient);
                break;
                case 4: 
                // Implement submitting inquiry logic 
                SubmitInquiry(loggedInPatient);
                break;
                case 5: 
                Console.WriteLine("Logging out.....");
                return; // Exit the patient loop
                default:
                Console.WriteLine("Invaild option. Please select a valid option");
                break;
            }
        }
      }
      else
      {
        Console.WriteLine("Invaild credentials. Please try again");
      }
    }    
    public static Patient Authenticate(string username, string password)
        {
            // Perform authentication based on username and password
            return patients.FirstOrDefault(patient =>
                patient.Username == username && patient.ValidatePassword(password));
         } 

// Helper method to generate a unique appointment ID
static int GenerateUniqueAppointmentId(List<Appointment> appointments)
{
    if (appointments.Count == 0)
    {
        // If there are no existing appointments, start with ID 1
        return 1;
    }
    else
    {
        // Find the highest existing appointment ID and add 1
        int maxId = appointments.Max(appointment => appointment.AppointmentId);
        return maxId + 1;
    }
}


        static void ScheduleAppointment(Patient patient, DataStorage dataStorage, List<Appointment> appointments)
        {
    Console.WriteLine("Scheduling an appointment...................");
    int appointmentId = GenerateUniqueAppointmentId(appointments);

    // Get the list of avaliable locations from our data storage
    List<Location> locations =  dataStorage.Locations;
    // Display available locations
    
    Console.WriteLine("Available locations");
    for (int i = 0; i < locations.Count; i++)
    {
        Console.WriteLine($"{i+1}.{locations[i].Name}");
    }


    // Ask the user to select a location
    Console.Write("Select location (1-10) :");
    int locationIndex = int.Parse(Console.ReadLine()) - 1; // Subtract one to match the index
    if (locationIndex >= 0 && locationIndex < locations.Count) 
    {
        Location selectedLocation = locations[locationIndex]; 

        // Display the available doctors at the selected location
        Console.WriteLine($"Available doctors at {selectedLocation.Name}.");
       for (int i = 0; i < selectedLocation.Doctors.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedLocation.Doctors[i].Name}");
        }

       
        // Ask the user to select a doctor
        Console.Write("Select a doctor (1-3): ");
        int doctorIndex = int.Parse(Console.ReadLine()) - 1; // Subtract one to match the index
        if (doctorIndex >= 0 && doctorIndex < selectedLocation.Doctors.Count)
        {
            Doctor selectedDoctor = selectedLocation.Doctors[doctorIndex]; 
            // Get appointment date and time from the user
            Console.Write("Enter appointment date (yyyy-MM-dd): ");
            string dateStr = Console.ReadLine();
            if (DateTime.TryParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime appointmentDate))
            {
                Console.Write("Enter appointment time (HH:mm): ");
                string timeStr = Console.ReadLine();
    
if (TimeSpan.TryParseExact(timeStr, "HH:mm", CultureInfo.InvariantCulture, out TimeSpan appointmentTime))
{
    // Combine the date and time components to create a valid DateTime
    DateTime appointmentDateTime = appointmentDate.Date.Add(appointmentTime);

    // Create appointment
    Appointment newAppointment = new Appointment(
          appointmentId,   // Replace with the actual appointment ID
        patient,
        selectedDoctor,
        selectedLocation,
        appointmentDateTime,
        AppointmentStatus.Scheduled
    );

    // Add appointment to the system appointment list
    appointments.Add(newAppointment);
    Console.WriteLine("Appointment scheduled successfully");
}


                else
                {
                    Console.WriteLine("Invalid time format. Please use HH:mm format.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd format.");
            }
        }
        else
        {
            Console.WriteLine("Invalid doctor selection.");
        }
    }
    else
    {
        Console.WriteLine("Invalid location selection.");
    }
}


//------------------------------------------------------------------------
static void ViewAppointments(Patient patient, List<Appointment> appointments)
{
    Console.WriteLine("Viewing appointments........");
    
    // Filter and display appointments for the logged-in patient
    List<Appointment> patientAppointments = GetPatientAppointments(patient, appointments);

    if (patientAppointments.Count > 0)
    {
        Console.WriteLine("Your Appointments");
        foreach (var appointment in patientAppointments)
        {
            Console.WriteLine($"Date and time: {appointment.DateTime}");
            Console.WriteLine($"Doctor: {appointment.Doctor.Name}");
            Console.WriteLine($"Location: {appointment.Location.Name}");
            Console.WriteLine($"Status: {appointment.Status}");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
    else
    {
        Console.WriteLine("You have no scheduled appointments");
    }
}

// Add this helper method to filter appointments for a specific patient
static List<Appointment> GetPatientAppointments(Patient patient, List<Appointment> appointments)
{
    // Filter appointments to find those associated with the patient
    return appointments.Where(appointment => appointment.Patient == patient).ToList();
}
//------------------------------------------------------------------------------
static void UpdateContactInformation(Patient patient)
{
    Console.WriteLine("Updating contact information.......");
    // Display the current contact infomation 
    Console.WriteLine("Current contact information");
   Console.WriteLine($"First Name: {patient.Firstname}");
    Console.WriteLine($"Last Name: {patient.Lastname}");
    Console.WriteLine($"Email: {patient.Email}");
    Console.WriteLine($"Phone: {patient.PhoneNumber}");
    Console.WriteLine($"Address: {patient.Address}");

    // prompt the user to update contact information
    Console.Write("Update First name (Press Enter to keep current): ");
    string updatedFirstname = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(updatedFirstname))
    {
        patient.Firstname = updatedFirstname;
    }
    Console.Write("Update Last name (Press Enter to keep current): ");
    string updatedLastname = Console.ReadLine();
     if (string.IsNullOrWhiteSpace(updatedLastname))
    {
        patient.Lastname = updatedLastname;
    }

    Console.Write("Update Email (Press enter to keep current ): ");
    string updatedEmail = Console.ReadLine();
     if (string.IsNullOrWhiteSpace(updatedEmail))
    {
        patient.Email = updatedEmail;
    }
     Console.Write("Update Phone number (Press enter to keep current): ");
    string updatedPhoneNumber = Console.ReadLine();
     if (string.IsNullOrWhiteSpace(updatedPhoneNumber))
    {
        patient.PhoneNumber = updatedPhoneNumber;
    } 
    Console.Write("Update Address (Press enter to current): ");
    string updatedAddress = Console.ReadLine();
     if (string.IsNullOrWhiteSpace(updatedAddress))
    {
        patient.Address = updatedAddress;
    }
    Console.WriteLine("Contact information updated Successfully");


}


//---------------------------------------------------------------------------------------


static void SubmitInquiry(Patient patient)
{
    Console.WriteLine("Submitting an inquiry...");

    // Prompt the user to provide inquiry details
    Console.Write("Enter symptoms: ");
    string symptoms = Console.ReadLine();

    Console.Write("Enter duration of symptoms: ");
    string durationOfSymptoms = Console.ReadLine();

    Console.Write("Enter previous medical history: ");
    string previousMedicalHistory = Console.ReadLine();

    Console.Write("Enter current medications: ");
    string currentMedications = Console.ReadLine();

    Console.Write("Enter allergies: ");
    string allergies = Console.ReadLine();

    Console.Write("Enter additional comments: ");
    string additionalComments = Console.ReadLine();

    Console.Write("Enter reason for booking: ");
    string reasonForBooking = Console.ReadLine();

    string illnessCategory = ChooseIllnessCategory();

    // Generate a unique inquiry ID
    int inquiryId = GenerateUniqueInquiryId(inquiries);

    // Create a new inquiry object
    Inquiry newInquiry = new Inquiry(
        inquiryId,
        patient,
        symptoms,
        durationOfSymptoms,
        previousMedicalHistory,
        currentMedications,
        allergies,
        additionalComments,
        reasonForBooking,
        illnessCategory
    );

    // Add the inquiry to the list of inquiries
    inquiries.Add(newInquiry);

    Console.WriteLine("Inquiry submitted successfully.");
}

// Helper method to generate a unique inquiry ID
static int GenerateUniqueInquiryId(List<Inquiry> inquiries)
{
    if (inquiries.Count == 0)
    {
        // If there are no existing inquiries, start with ID 1
        return 1;
    }
    else
    {
        // Find the highest existing inquiry ID and add 1
        int maxId = inquiries.Max(inquiry => inquiry.InquiryId);
        return maxId + 1;
    }
}

static string ChooseIllnessCategory()
{
    Console.WriteLine("Select an Illeness Category");
    Console.WriteLine("1. General check-up");
    Console.WriteLine("2. Dermatology");
    Console.WriteLine("3. Orthopedics");
    Console.WriteLine("4. Cardiology");

    while (true)
    {
        Console.WriteLine("Enter your chioce");
        int chioce = Convert.ToInt32(Console.ReadLine());
        switch (chioce)
        {
            case 1: 
            return "General check-up";
            
            case 2:
            return "Dermatology";
            case 3:
            return "Orthopedics";
            case 4: 
            return "Cardiology"; 

            default:
            Console.WriteLine("Invalid choice please select a valid number");
            break;
        }
    }
   }
}
}
}