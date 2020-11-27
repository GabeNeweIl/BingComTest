using OpenQA.Selenium;

namespace BingComTests
{
    public class Data
    {
        public readonly By _signinLink = By.XPath("//span[@class='sw_spd id_avatar']");
        public readonly By _emailField = By.XPath("//input[@id='i0116']");
        public readonly By _passwordField = By.XPath("//input[@id='i0118']");
        public readonly By _loginButton = By.XPath("//input[@id='idSIButton9']");

        public readonly By _logoutLink = By.XPath("//span[@id='id_n']");
        public readonly By _logoutButton = By.XPath("//span[@class='id_link_text']");

        public readonly By _searchFrom = By.XPath("//input[@id='sb_form_q']");
        public readonly By _searchButton = By.XPath("//label[@class='search icon tooltip']");
        public readonly By _relatedSearchList = By.XPath("//div[@class='b_rs']");
        public readonly By _searchListResult = By.XPath("//ol[@id='b_results']");
        public readonly By _searchResult = By.XPath("li[@class='b_algo']");

        public readonly By _menubarLink = By.XPath("//a[@id='id_sc']");
        public readonly By _settingLink = By.XPath("//div[@id='hbsettings']");
        public readonly By _languageLink = By.XPath("//a[@h='ID=SERP.5018,5366.1']");
        public readonly By _englishLanguage = By.XPath("//a[@h='ID=SERP,5034.1']");
        public readonly By _imagesLink = By.XPath("//li[@id='images']/a");
        public readonly By _locationLink = By.XPath("//a[@h='ID=SERP.5018,5367.1']");
        public readonly By _crsTrends = By.XPath("//ul[@id='trending_now_tile']");
        //public readonly By _USALocationLink = By.XPath("//a[@href='https://www.bing.com/account/action?scope=web&setmkt=en-us&FORM=W5WA&uid=1AD0BE71&sid=0AC602E5B2BB6B8117260D6EB3D06A95']");
        public readonly By _USALocationLink = By.XPath("//*[@id='region-section-content']/div/div/div[2]/div/div[4]/div/div[3]/ul/li[67]/a");

        public readonly string _expectedLogin = "Сойка";
    }
}
