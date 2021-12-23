using System.ComponentModel.DataAnnotations;
public class FileUploadModel
{
    [DataType(DataType.Upload)]
    [Display(Name = "Upload File")]
    [Required(ErrorMessage = "Please choose file to upload.")]
    public string file { get; set; }
}