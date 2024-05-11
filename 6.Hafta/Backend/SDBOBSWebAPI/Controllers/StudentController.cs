using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDBOBSWebAPI.Entities;
using SDBOBSWebAPI.Models;

namespace SDBOBSWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private static readonly List<StudentEntity> _students = [
            new(1, "Seda", "Diril Boyraz", 22, "BE105"),
            new(2, "Alara", "Çelebi", 19, "BE105"),
            new(3, "Selen", "Yıldırım", 23, "BE105"),
            new(4, "Murat", "Keskin", 15, "BE105"),
            new(5, "Ahmet", "Koç", 12, "BE105"),
            new(6, "Olcay", "Okumuş", 8, "BE105")
        ];
    private static int _id = _students.Count + 1;
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudentEntity>))]
    public IActionResult Get()
    {
        return Ok(_students);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StudentEntity))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetStudentById([FromRoute] int id)
    {
        var student = _students.FirstOrDefault(x => x.Id == id);
        if (student == null)
            return NotFound();
        return Ok(student);
    }
    [HttpPost("html-post-body")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StudentEntity))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Post([FromBody] StudentModel model)
    {
        if (!ModelState.IsValid) //Response yönetmek için. Modelstate ControllerBase'den gelmekte.
        {
            return BadRequest(ModelState);
        }
        var isModelUnique = _students.FirstOrDefault(x => x.Number == model.Number);
        if (isModelUnique != null)
            return BadRequest("Aynı numaraya sahip öğrenci var");

        StudentEntity newStudent = new StudentEntity()
        {
            Id = _id++,
            Name = model.Name.Substring(0, 1).ToUpper() + model.Name.Substring(1).ToLower(),
            Surname = model.Surname.Substring(0, 1).ToUpper() + model.Surname.Substring(1).ToLower(),
            Number = model.Number,
            ClassName = model.ClassName.ToUpper()
        };
        _students.Add(newStudent);
        return Ok(newStudent);

    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Put([FromRoute] int id, [FromBody] StudentModel updateModel)
    {
        var studentToUpdate = _students.FirstOrDefault(x => x.Id == id);
        if (studentToUpdate == null)
            return NotFound();
        studentToUpdate.Name = updateModel.Name.Substring(0, 1).ToUpper() + updateModel.Name.Substring(1).ToLower();
        studentToUpdate.Surname = updateModel.Surname.Substring(0, 1).ToUpper() + updateModel.Surname.Substring(1).ToLower();
        studentToUpdate.Number = updateModel.Number;
        studentToUpdate.ClassName = updateModel.ClassName.ToUpper();
        return Ok();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        var studentToDelete = _students.FirstOrDefault(x => x.Id == id);
        if (studentToDelete == null)
            return NoContent();
        _students.Remove(studentToDelete);
        return Ok();
    }
}
