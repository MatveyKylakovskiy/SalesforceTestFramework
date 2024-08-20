using HomeWork30APITest.ApiTests.ApiMethotds;
using HomeWork30APITest.ApiTests.ReqresAPI.Models.Response;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Builders;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response;
using System.ComponentModel;

namespace SalesforceTestFramework.API.APITests
{
    public class Tests : BaseAPITest
    {
        [Test]
        [DisplayName("Get List of Users")]
        public void GetMethodTest1()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users?page=2", client);
            
            ListOfUsersModel listOfUsers = getMethodObj.ReturnJsonContent< ListOfUsersModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(listOfUsers.Users[0].id, Is.EqualTo(7));
            Assert.That(listOfUsers.Users[1].First_Name, Is.EqualTo("Lindsay"));
            Assert.That(listOfUsers.Users[2].Email, Is.EqualTo("tobias.funke@reqres.in"));
            Assert.That(listOfUsers.Users[3].Last_Name, Is.EqualTo("Fields"));
        }

        [Test]
        [DisplayName("Get single User")]
        public void GetMethodTest2()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users/2", client);

            SingleUserModel singleUser = getMethodObj.ReturnJsonContent<SingleUserModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleUser.data.id, Is.EqualTo(2));
            Assert.That(singleUser.data.first_name, Is.EqualTo("Janet"));
            Assert.That(singleUser.data.email, Is.EqualTo("janet.weaver@reqres.in"));
            Assert.That(singleUser.data.last_name, Is.EqualTo("Weaver"));
        }

        [Test]
        [DisplayName("Single User not found")]
        public void GetMethodTest3()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users/23", client);

            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(404), "status code is not 404");
        }

        [Test]
        [DisplayName("Get LIST <RESOURCE>")]
        public void GetMethodTest4()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown", client);

            ListOfResourseModel singleResourse = getMethodObj.ReturnJsonContent<ListOfResourseModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleResourse.Items[0].id, Is.EqualTo(1));
            Assert.That(singleResourse.Items[1].Name, Is.EqualTo("fuchsia rose"));
            Assert.That(singleResourse.Items[2].Color, Is.EqualTo("#BF1932"));
            Assert.That(singleResourse.Items[3].Year, Is.EqualTo(2003));
            Assert.That(singleResourse.Items[4].PantoneValue, Is.EqualTo("17-1456"));
        }

        [Test]
        [DisplayName("Get single <RESOURCE>")]
        public void GetMethodTest5()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown/2", client);

            SingleResourseModel singleResourse = getMethodObj.ReturnJsonContent<SingleResourseModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleResourse.data.id, Is.EqualTo(2));
            Assert.That(singleResourse.data.name, Is.EqualTo("fuchsia rose"));
            Assert.That(singleResourse.data.year, Is.EqualTo(2001));
            Assert.That(singleResourse.data.color, Is.EqualTo("#C74375"));
            Assert.That(singleResourse.data.pantone_value, Is.EqualTo("17-2031"));
        }

        [Test]
        [DisplayName("Single Resourse not found")]
        public void GetMethodTest6()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown/23", client);

            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(404), "status code is not 404");
        }

        [Test]
        [DisplayName("CREATE User")]
        public void PostMethodTest7()
        {
            var jsonReq = new UserBuilder()
                .Name("morpheus")
                .Job("leader")
                .Build();

            var postMethodObj = new MethodPOST();
            postMethodObj.SendPostMethod("users", client, jsonReq);

            var statusCode = postMethodObj.ReturnStatusCode();

            CreateUserModel singleUser = postMethodObj.ReturnJsonContent<CreateUserModel>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(201), "status code is not 201");

            Assert.That(singleUser.Name, Is.EqualTo("morpheus"));
            Assert.That(singleUser.Job, Is.EqualTo("leader"));
            Assert.That(singleUser.CreatedAt, Is.EqualTo(DateTime.UtcNow).Within(TimeSpan.FromSeconds(2)));
        }

        [Test]
        [DisplayName("Update User Put")]
        public void PutMethodTest8()
        {
            var jsonReq = new UserBuilder()
                .Name("morpheus")
                .Job("zion resident")
                .Build();

            var putMethodObj = new MethodPUT();
            putMethodObj.SendPutMethod("users/2", client, jsonReq);

            var statusCode = putMethodObj.ReturnStatusCode();

            CreateUserModel singleUser = putMethodObj.ReturnJsonContent<CreateUserModel>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            Assert.That(singleUser.Name, Is.EqualTo("morpheus"));
            Assert.That(singleUser.Job, Is.EqualTo("zion resident"));
            Assert.That(singleUser.UpdatedAt, Is.EqualTo(DateTime.UtcNow).Within(TimeSpan.FromSeconds(2)));
        }

        [Test]
        [DisplayName("Update User Path")]
        public void PathMethodTest9()
        {
            var jsonReq = new UserBuilder()
                .Name("morpheus")
                .Job("zion resident")
                .Build();

            var pathMethodObj = new MethodPATCH();
            pathMethodObj.SendPatchMethod("users/2", client, jsonReq);

            var statusCode = pathMethodObj.ReturnStatusCode();

            CreateUserModel singleUser = pathMethodObj.ReturnJsonContent<CreateUserModel>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            Assert.That(singleUser.Name, Is.EqualTo("morpheus"));
            Assert.That(singleUser.Job, Is.EqualTo("zion resident"));
            Assert.That(singleUser.UpdatedAt, Is.EqualTo(DateTime.UtcNow).Within(TimeSpan.FromSeconds(2)));
        }

        [Test]
        [DisplayName("Delete user")]
        public void DeleteMethodTest10()
        {
           
            var deleteMethodObj = new MethodDELETE();
            deleteMethodObj.SendDeleteMethod("users/2", client);

            var statusCode = deleteMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(204), "status code is not 204");
        }

        [Test]
        [DisplayName("Register user positive")]
        public void PostMethodTest11()
        {
            var jsonReq = new RegisterUserBuilder()
                .Email("eve.holt@reqres.in")
                .Password("pistol")
                .Build();

            var postMethodObj = new MethodPOST();
            postMethodObj.SendPostMethod("register", client, jsonReq);

            var statusCode = postMethodObj.ReturnStatusCode();

            RegisterResponse userData = postMethodObj.ReturnJsonContent<RegisterResponse>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            Assert.That(userData.Id, Is.EqualTo(4));
            Assert.That(userData.Token, Is.EqualTo("QpwL5tke4Pnpja7X4"));
        }

        [Test]
        [DisplayName("Register user negative")]
        public void PostMethodTest12()
        {
            var jsonReq = new RegisterUserBuilder()
                .Email("eve.holt@reqres.in")
                .Build();

            var postMethodObj = new MethodPOST();
            postMethodObj.SendPostMethod("register", client, jsonReq);

            var statusCode = postMethodObj.ReturnStatusCode();

            RegisterResponse userData = postMethodObj.ReturnJsonContent<RegisterResponse>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(400), "status code is not 400");

            Assert.That(userData.Error, Is.EqualTo("Missing password"));
        }

        [Test]
        [DisplayName("Login user positive")]
        public void PostMethodTest13()
        {
            var jsonReq = new RegisterUserBuilder()
                .Email("eve.holt@reqres.in")
                .Password("cityslicka")
                .Build();

            var postMethodObj = new MethodPOST();
            postMethodObj.SendPostMethod("login", client, jsonReq);

            var statusCode = postMethodObj.ReturnStatusCode();

            RegisterResponse userData = postMethodObj.ReturnJsonContent<RegisterResponse>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            Assert.That(userData.Token, Is.EqualTo("QpwL5tke4Pnpja7X4"));
        }

        [Test]
        [DisplayName("Login user negative")]
        public void PostMethodTest14()
        {
            var jsonReq = new RegisterUserBuilder()
                .Email("peter@klaven")
                .Build();

            var postMethodObj = new MethodPOST();
            postMethodObj.SendPostMethod("login", client, jsonReq);

            var statusCode = postMethodObj.ReturnStatusCode();

            RegisterResponse userData = postMethodObj.ReturnJsonContent<RegisterResponse>();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(400), "status code is not 400");

            Assert.That(userData.Error, Is.EqualTo("Missing password"));
        }

        [Test]
        [DisplayName("get with delay")]
        public void GetMethodTest15()
        {
            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users?delay=3", client);

            ListOfUsersModel listOfUsers = getMethodObj.ReturnJsonContent<ListOfUsersModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(listOfUsers.Users[0].id, Is.EqualTo(1));
            Assert.That(listOfUsers.Users[1].First_Name, Is.EqualTo("Janet"));
            Assert.That(listOfUsers.Users[2].Email, Is.EqualTo("emma.wong@reqres.in"));
            Assert.That(listOfUsers.Users[3].Last_Name, Is.EqualTo("Holt"));
        }
    }
}