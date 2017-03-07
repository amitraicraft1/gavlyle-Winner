﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Winner;
using winner.Models;

namespace winner.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                SendMail mail = new SendMail();
                List<string> str = new List<string>();
                str.Add(model.Email);
                System.Text.StringBuilder str1 = new System.Text.StringBuilder();

                str1.Append("<style type='text/css'>" +

    "@media screen and (max-width: 600px) {" +
    "table[class='container'] {" +
    "  width: 95% !important;" +
    "}" +
    "}" +

    "#outlook a {padding:0;}" +

    "body{width:100% !important; -webkit-text-size-adjust:100%; -ms-text-size-adjust:100%;  padding:0;}" +
    ".ExternalClass {width:100%;}" +
    ".ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {line-height: 100%;}" +
    "#backgroundTable { padding:0; width:100% !important; line-height: 100% !important;}" +
    "img {outline:none; text-decoration:none; -ms-interpolation-mode: bicubic;}" +
    "a img {border:none;}" +
    ".image_fix {display:block;}" +
    "p {}" +
    "h1, h2, h3, h4, h5, h6 {color: #ff725e !important;}" +

    "h1 a, h2 a, h3 a, h4 a, h5 a, h6 a {color: blue !important;}" +

    "h1 a:active, h2 a:active,  h3 a:active, h4 a:active, h5 a:active, h6 a:active {" +
    "	color: red !important;" +
     "}" +

    "h1 a:visited, h2 a:visited,  h3 a:visited, h4 a:visited, h5 a:visited, h6 a:visited {" +
        "color: purple !important;" +
    "}" +

    "table td {border-collapse: collapse;}" +

    "table { border-collapse:collapse;   }" +

    "a {color: #000;}" +

    "@media only screen and (max-device-width: 480px) {" +

        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: black; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important; /* or whatever your want */" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +


    "@media only screen and (min-device-width: 768px) and (max-device-width: 1024px) {" +
        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: blue; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important;" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +

    "@media only screen and (-webkit-min-device-pixel-ratio: 2) {" +
        "/* Put your iPhone 4g styles in here */" +
    "}" +

    "@media only screen and (-webkit-device-pixel-ratio:.75){" +
        "/* Put CSS for low density (ldpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1){" +
        "/* Put CSS for medium density (mdpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1.5){" +
        "/* Put CSS for high density (hdpi) Android layouts in here */" +
    "}" +
    "/* end Android targeting */" +
    "h2{" +
        "color:#181818;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:22px;" +
        "line-height: 22px;" +
        "font-weight: normal;" +
    "}" +
    "a.link1{" +

    "}" +
    "a.link2{" +
        "color:#fff;" +
        "text-decoration:none;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "color:#fff;border-radius:4px;" +
    "}" +
    "p{" +
        "color:#555;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "line-height:160%;" +
    "}" +
    "</style>");
                str1.Append("<script type='colorScheme' class='swatch active'>" +
    "{" +
    "'name':'Default'," +
    "'bgBody':'ffffff'," +
    "'link':'fff'," +
    "'color':'555555'," +
    "'bgItem':'ffffff'," +
    "'title':'181818'" +
    "}" +
    "</script>");
                str1.Append("<table cellpadding='0' width='100%' cellspacing='0' border='0' id='backgroundTable' class='bgBody'>" +
    "<tr>" +
    "<td>" +
    "<table cellpadding='0' width='620' class='container' align='center' cellspacing='0' border='0'>" +
    "<tr>" +
    "<td>" +
    "<!-- Tables are the most common way to format your email consistently. Set your table widths inside cells and in most cases reset cellpadding, cellspacing, and border to zero. Use nested tables as a way to space effectively in your message. -->" +


    "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
       "<tr>" +
           "<td class='movableContentContainer bgItem'>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='3' align='center' style='padding-bottom:10px;padding-top:25px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='center' >" +
                                       "<h2 style='color: #ff725e !important;'>Enquiry</h2>" +
                                   "</div>" +
                               "</div>" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='100'>&nbsp;</td>" +
                           "<td width='400' align='center'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +

                                   "<p>" + model.Name + "</p>" +
                                   "<p>" + model.Email + "</p>" +
                                   "<p>" + model.phone + "</p>" +
                                   "<p>" + model.Message + "</p>" +

                                       "<p >");

                str1.Append("Thank you for your Submitting your details,we have got your enquiry</p>");
                str1.Append("</div>" +
                               "</div>" +
                           "</td>" +
                           "<td width='100'>&nbsp;</td>" +
                       "</tr>" +
                   "</table>" +

               "</div>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='2' style='padding-top:65px;'>" +
                               "<hr style='height:1px;border:none;color:#333;background-color:#ddd;' />" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='60%' height='70' valign='middle' style='padding-bottom:20px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +
                                       "<span style='font-size:13px;color:#181818;font-family:Helvetica, Arial, sans-serif;line-height:200%;'><a href='http://winner.itsoftserve.com/'>Winner</a></span>" +
                                       "<br/>" +

                                   "</div>" +
                               "</div>" +
                           "</td>" +
                           "</tr>" +
                               "</table>" +
                           "</td>" +
                       "</tr>" +
                   "</table>" +
               "</div>" +


           "</td>" +
       "</tr>" +
    "</table>" +




    "</td></tr></table>" +

    "</td>" +
    "</tr>" +
    "</table>");

                mail.SendEmailMessage(str1.ToString(), "Enquiry confirmation", str);
            }
            return View();
        }
    }
}