using System.Threading;
using System.Threading.Tasks;

namespace WebApp.App
{
    public interface IPrescription
    {
        Task<bool> FillPrescription();
    }

    public class WalgreensPrescription : IPrescription
    {
        public async Task<bool> FillPrescription()
        {
            await Task.Factory.StartNew(() => { Thread.Sleep(1000); });

            return true;
        }
    }

    public class PrescriptionLoader
    {
        private readonly IPrescription _prescription;

        public PrescriptionLoader(IPrescription prescription)
        {
            _prescription = prescription;
        }

        public async Task<bool> Load()
        {
            return await _prescription.FillPrescription();
        }

        /// <summary>
        /// normally I would not expose this, but for testing sake I did
        /// </summary>
        public IPrescription Prescription => _prescription;
    }
}