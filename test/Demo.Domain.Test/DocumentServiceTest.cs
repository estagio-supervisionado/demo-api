using Demo.Domain.Services;
using Xunit;

namespace Demo.Domain.Test
{
    public class DocumentServiceTest
    {
        [Fact]
        public void GetData_deve_retornar_dados()
        {

            var service = new DocumentService(null);

            var data = service.GetData();

            Assert.NotEmpty(data);
        }
    }
}
