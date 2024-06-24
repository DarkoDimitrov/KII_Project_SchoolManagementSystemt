

    using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Models.ViewModels;
using SchoolManagmentSystem.Repository.RepositoryImplementation;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Service.ServiceImplementation
    {
        public class SubjectService:ISubjectService
        {
            private readonly ISubjectRepository subjectRepository;
            private readonly ILiteratureService literatureService;

        public SubjectService(ISubjectRepository subjectrepository, ILiteratureService literatureservice)
            {
            literatureService = literatureservice;
                subjectRepository = subjectrepository;
            }

            public List<Subject> GetAllSubjects()
            {
                return subjectRepository.GetAllSubjects();
            }

            public Subject GetSubjectById(int id)
            {
                return subjectRepository.GetSubjectById(id);
            }
            public SubjectDetailsViewModel GetSubjectDetails(int id)
            {
            var subject = subjectRepository.GetSubjectById(id);
            var literatures = literatureService.GetLiteraturesBySubjectId(id);
            var viewModel = new SubjectDetailsViewModel
            {
                Subject = subject,
                Literatures = literatures
            };
            return viewModel;
        }

        public void AddSubject(Subject subject)
            {
                subjectRepository.AddSubject(subject);
            }

            public void UpdateSubject(Subject subject)
            {
                subjectRepository.UpdateSubject(subject);
            }

            public void DeleteSubject(int id)
            {
                subjectRepository.DeleteSubject(id);
            }
        }
    }


