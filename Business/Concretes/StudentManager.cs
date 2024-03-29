using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Student.Requests;
using Business.Dtos.Student.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class StudentManager : IStudentService
{
    private IStudentDal _studentDal;
    private IMapper _mapper;

    public StudentManager(IStudentDal studentDal, IMapper mapper)
    {
        _studentDal = studentDal;
        _mapper = mapper;
    }

    public async Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest)
    {
        var student = _mapper.Map<Student>(createStudentRequest);
        var createStudent = await _studentDal.AddAsync(student);
        return _mapper.Map<CreatedStudentResponse>(createStudent);
    }

    public async Task<DeletedStudentResponse> DeleteAsync(DeleteStudentRequest deleteStudentRequest)
    {
        var student = await _studentDal.GetAsync(c => c.Id == deleteStudentRequest.Id);
        var deleteStudent = await _studentDal.DeleteAsync(student);
        return _mapper.Map<DeletedStudentResponse>(deleteStudent);
    }

    public async Task<GetStudentResponse> GetById(GetStudentRequest getStudentRequest)
    {
        var getStudent = await _studentDal.GetAsync(c => c.Id == getStudentRequest.Id);
        return _mapper.Map<GetStudentResponse>(getStudent);
    }

    public async Task<IPaginate<GetListedStudentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _studentDal.GetListAsync(include: p => p.Include(p => p.User), index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedStudentResponse>>(getList);
    }

    public async Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentrequest)
    {
        var student = _mapper.Map<Student>(updateStudentrequest);
        var updatedStudent = await _studentDal.UpdateAsync(student);
        return _mapper.Map<UpdatedStudentResponse>(updatedStudent);
    }
}