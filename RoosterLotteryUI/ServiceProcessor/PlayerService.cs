using System.Numerics;
using System.Text;
using System.Text.Json;
using RoosterLottery.Models;
using RoosterLotteryUI.Properties;
using RestSharp;
using RestSharp.Serializers.Json;

namespace Client.Services
{
    internal class PlayerService
    {
        private readonly RestClient _restClientPlayer;

        internal PlayerService()
        {
            _restClientPlayer = new RestClient($"{Resources.ApiUrl}/api/Player/");
        }

        internal async Task<List<Player?>> Load()
        {
            var request = new RestRequest($"{nameof(Load)}", Method.Get);

            RestResponse<List<Player>> response = await _restClientPlayer.ExecuteAsync<List<Player>>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<Player?> GetById(int id)
        {
            var request = new RestRequest($"{nameof(GetById)}/{id}", Method.Get);

            RestResponse<Player> response = await _restClientPlayer.ExecuteAsync<Player>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Handle the not found response
                MessageBox.Show("No player found with the given ID.");
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<Player> SearchPlayerByPhoneNumber(string phoneNumber)
        {
            var request = new RestRequest($"{nameof(SearchPlayerByPhoneNumber)}", Method.Get);
            request.AddQueryParameter($"{nameof(phoneNumber)}", phoneNumber);

            RestResponse<Player> response = await _restClientPlayer.ExecuteAsync<Player>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Handle the not found response
                MessageBox.Show("No player found with the given phone number.");
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<bool> Save(Player player)
        {
            var request = new RestRequest($"{nameof(Save)}", Method.Post);
            request.AddJsonBody(player); // Serializes player object to JSON

            RestResponse response = await _restClientPlayer.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return false;
        }

        internal async Task<bool> Delete(int id)
        {
            var request = new RestRequest($"{nameof(Delete)}/{id}", Method.Delete);

            RestResponse response = await _restClientPlayer.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return false;
        }
    }
}
