    public class UserServiceClient{
        private readonly HttpClient _httpClient;

        public UserServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public  async Task<List<UserInfo>> GetUsers()
        {
            var response = await _httpClient.GetAsync("api/users");
            
            if (response != null)
            {
                var users = await response.Content.ReadFromJsonAsync<List<UserInfo>>();
                foreach (var user in users)
                {
                    Console.WriteLine("user" + user?.gmail + user?.name);
                }
                return users;
            }
            
            return new List<UserInfo>();
        }

        
    }




