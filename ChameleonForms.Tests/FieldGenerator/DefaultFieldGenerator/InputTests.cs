﻿using ApprovalTests.Html;
using ChameleonForms.Component.Config;
using ChameleonForms.Templates;
using NUnit.Framework;

namespace ChameleonForms.Tests.FieldGenerator.DefaultFieldGenerator
{
    class InputTests : DefaultFieldGeneratorShould
    {
        [Test]
        public void Use_correct_html_for_text_field()
        {
            var g = Arrange(m => m.RequiredString);

            var result = g.GetFieldHtml(new FieldConfiguration { Attributes = new HtmlAttributes(data_attr => "value") });

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_text_field_with_value()
        {
            var g = Arrange(m => m.RequiredString, m => m.RequiredString = "asdf");

            var result = g.GetFieldHtml(new FieldConfiguration { Attributes = new HtmlAttributes(data_attr => "value") });

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_decimal_field()
        {
            var g = Arrange(m => m.Decimal, m => m.Decimal = 1.2000m);

            var result = g.GetFieldHtml(null);

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_decimal_field_with_format_string()
        {
            var g = Arrange(m => m.Decimal, m => m.Decimal = 1.2000m);

            var result = g.GetFieldHtml(new FieldConfiguration().WithFormatString("{0:f2}"));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_password_field()
        {
            var g = Arrange(m => m.Password);

            var result = g.GetFieldHtml(new FieldConfiguration { Attributes = new HtmlAttributes(data_attr => "value") });

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_textarea()
        {
            var g = Arrange(m => m.Textarea);

            var result = g.GetFieldHtml(new FieldConfiguration { Attributes = new HtmlAttributes(data_attr => "value") });

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_file_upload()
        {
            var g = Arrange(m => m.FileUpload);

            var result = g.GetFieldHtml(new FieldConfiguration { Attributes = new HtmlAttributes(data_attr => "value") });

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }
    }
}