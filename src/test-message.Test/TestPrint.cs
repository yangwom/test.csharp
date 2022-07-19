using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory(DisplayName = "testando o parametro de print")]
    [InlineData("Ola", "Ola")]
    [InlineData("Breno o melhor", "Breno o melhor")]
    [InlineData("Meirelles topzeira", "Meirelles topzeira")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            Message.PrintMsg(Send);

            string result = NewOutput.ToString().Trim();

            result.Should().Be(Expected);      
        }
    }
}
