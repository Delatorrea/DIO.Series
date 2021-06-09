using System;
using DIO.Series.Models.Enum;

namespace DIO.Series.Models
{
  public class Serie : Identity
  {
    private Gender Gender { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }
    public bool Valid { get; private set; }

    public Serie(int id, Gender gender, string title, string description, int year)
    {
      this.Id = Id;
      this.Gender = gender;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Date = DateTime.Now;
      this.Valid = true;
    }

    public void Invalidate(){
      this.Valid = false;
    }

    public int GetId(){
        return this.Id;
    }

    public string GetTitle()
    {
      return this.Title;
    }

    public override string ToString()
    {
      return "Gênero = " + this.Gender + Environment.NewLine
           + "Título = " + this.Title + Environment.NewLine
           + "Descrição = " + this.Description + Environment.NewLine
           + "Ano = " + this.Year + Environment.NewLine
           + "Válido = " + this.Valid + Environment.NewLine;
    }
  }
}