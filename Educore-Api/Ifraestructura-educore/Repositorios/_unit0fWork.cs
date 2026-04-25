using Ifraestructura_educore.Data;
using Ifraestructura_educore.Repositorios;

namespace Ifraestructura_educore.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly Educore_Context context;

        public WorkshopRepositorio Workshops { get; }
        public CategoryRepositorio Categories { get; }
        public InstructorsRepositorio Instructors { get; }
        public StudentsRepositorio Students { get; }
        public RegistrationsRepositorio Registrations { get; }
        public AttendanceRepositorio Attendances { get; }
        public PaymentRepositorio Payments { get; }
        public ClassroomsRepositorio Classrooms { get; }
        public WorkshopClassroomRepositorio WorkshopClassrooms { get; }
        public AdministrationRepositorio Administrations { get; }

        public UnitOfWork(
            Educore_Context context,
            WorkshopRepositorio workshopRepositorio,
            CategoryRepositorio categoryRepositorio,
            InstructorsRepositorio instructorsRepositorio,
            StudentsRepositorio studentsRepositorio,
            RegistrationsRepositorio registrationsRepositorio,
            AttendanceRepositorio attendanceRepositorio,
            PaymentRepositorio paymentRepositorio,
            ClassroomsRepositorio classroomsRepositorio,
            WorkshopClassroomRepositorio workshopClassroomRepositorio,
            AdministrationRepositorio administrationRepositorio
        )
        {
            this.context = context;

            Workshops = workshopRepositorio;
            Categories = categoryRepositorio;
            Instructors = instructorsRepositorio;
            Students = studentsRepositorio;
            Registrations = registrationsRepositorio;
            Attendances = attendanceRepositorio;
            Payments = paymentRepositorio;
            Classrooms = classroomsRepositorio;
            WorkshopClassrooms = workshopClassroomRepositorio;
            Administrations = administrationRepositorio;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}