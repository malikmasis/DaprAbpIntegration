using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DaprExample.Pages;

public class Index_Tests : DaprExampleWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
