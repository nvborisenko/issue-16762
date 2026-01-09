using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

OpenQA.Selenium.Internal.Logging.Log.SetLevel(OpenQA.Selenium.Internal.Logging.LogEventLevel.Trace);

var options = new ChromeOptions();
options.AddArgument("--headless=new");

using var driver = new ChromeDriver(options);

driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
var fileInput = driver.FindElement(By.CssSelector("input[type='file']"));
string filePath = Path.GetFullPath("Manuscript_Unicode_€.docx");
fileInput.SendKeys(filePath);
