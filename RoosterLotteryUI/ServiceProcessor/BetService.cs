using System.Numerics;
using System.Text;
using System.Text.Json;
using RoosterLottery.Models;
using RoosterLotteryUI.Properties;
using RestSharp;
using RestSharp.Serializers.Json;

namespace Client.Services
{
    internal class BetService
    {
        private readonly RestClient _restClientBet;

        internal BetService()
        {
            _restClientBet = new RestClient($"{Resources.ApiUrl}/api/Bet/");
        }

        internal async Task<List<Bet?>> Load()
        {
            var request = new RestRequest($"{nameof(Load)}", Method.Get);

            RestResponse<List<Bet>> response = await _restClientBet.ExecuteAsync<List<Bet>>(request);

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

        internal async Task<Bet?> GetById(int id)
        {
            var request = new RestRequest($"{nameof(GetById)}/{id}", Method.Get);

            RestResponse<Bet> response = await _restClientBet.ExecuteAsync<Bet>(request);

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

        internal async Task<bool> Save(Bet player)
        {
            var request = new RestRequest($"{nameof(Save)}", Method.Post);
            request.AddJsonBody(player); // Serializes player object to JSON

            RestResponse response = await _restClientBet.ExecuteAsync(request);

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

            RestResponse response = await _restClientBet.ExecuteAsync(request);

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
