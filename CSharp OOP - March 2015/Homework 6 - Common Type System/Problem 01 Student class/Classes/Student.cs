namespace Problem_01_Student_class.Classes
{
    using Problem_01_Student_class.Enumeration;
    using System;
    /* Define a class Student, which contains data about a student – first, 
     * middle and last name, SSN, permanent address, mobile phone e-mail, 
     * course, specialty, university, faculty. Use an enumeration for the 
     * specialties, universities and faculties. */
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;

        private Student()
        { }

        public Student(string firstName, string middleName, string lastName,
            string address, string ssn, string mobilePhone, string email, uint course,
            Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.SSN = ssn;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or empty.");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }
                this.lastName = value;
            }
        }

        public string SSN { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public uint Course { get; set; }

        public Specialty Specialty { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set; }

        /* Override the standard methods, inherited by System.Object: Equals(), 
         * ToString(), GetHashCode() and operators == and !=. */
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student rhs = obj as Student;
            if (rhs == null)
            {
                return false;
            }

            if (this.FirstName != rhs.FirstName ||
                this.MiddleName != rhs.MiddleName ||
                this.LastName != rhs.LastName ||
                this.SSN != rhs.SSN ||
                this.Address != rhs.Address ||
                this.MobilePhone != rhs.MobilePhone ||
                this.Email != rhs.Email ||
                this.Course != rhs.Course ||
                this.Specialty != rhs.Specialty ||
                this.University != rhs.University ||
                this.Faculty != rhs.Faculty)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^
                   this.LastName.GetHashCode() ^ this.Address.GetHashCode() ^ this.SSN.GetHashCode() ^
                   this.MobilePhone.GetHashCode() ^ this.Email.GetHashCode() ^
                   this.Course.GetHashCode() ^ this.Specialty.GetHashCode() ^
                   this.University.GetHashCode() ^ this.Faculty.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nMiddle name: {1}\nLast name: {2}\nAddress: {3}\nMobile phone: {4}\nEmail: {5}\nCourse: {6}\nSpeciality: {7}\nUniversity: {8}\nFaculty: {9}\nSSN: {10}\n",
                                  this.FirstName, this.MiddleName, this.LastName, this.Address, this.MobilePhone, this.Email,
                                  this.Course, this.Specialty, this.University, this.Faculty, this.SSN);
        }

        public static bool operator ==(Student lhs, Student rhs)
        {
            return Student.Equals(lhs, rhs);
        }

        public static bool operator !=(Student lhs, Student rhs)
        {
            return !Student.Equals(lhs, rhs);
        }

        /* Problem 2. IClonable
         * Add implementations of the ICloneable interface. The Clone() method should deeply copy 
         * all object's fields into a new object of type Student. 
         */
        public object Clone()
        {
            // it could be done with Memberwise clone because it does not contain any reference types yet
            // but our task is to make deep clone so...
            Student clone = new Student()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                Address = this.Address,
                MobilePhone = this.MobilePhone,
                Email = this.Email,
                SSN = this.SSN,
                Course = this.Course,
                Specialty = this.Specialty,
                University = this.University,
                Faculty = this.Faculty,
            };

            return clone;
        }
        /* Problem 3. IComparable
         * Implement the IComparable<Student> interface to compare students by names 
         * (as first criteria, in lexicographic order) and by social security number 
         * (as second criteria, in increasing order). 
         */

        public int CompareTo(Student other)
        {
            string fullnameThis = this.FirstName + this.MiddleName + this.LastName;
            string fullnameOther = other.FirstName + other.MiddleName + other.LastName;
            int namesCompare = fullnameThis.CompareTo(fullnameOther);
            int ssnCompare = this.SSN.CompareTo(other.SSN);

            if (namesCompare == 0)
            {
                return ssnCompare;
            }

            return namesCompare;
        }
    }
}
