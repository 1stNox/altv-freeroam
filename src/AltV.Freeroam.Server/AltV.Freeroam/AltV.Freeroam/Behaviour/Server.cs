using AltV.Freeroam.Creational;
using AltV.Freeroam.Structure;
using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Behaviour
{
    public class Server : AsyncResource
    {
        #region Factories

        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new ServerPlayerFactory();
        }

        public override IEntityFactory<IVehicle> GetVehicleFactory()
        {
            return new ServerVehicleFactory();
        }

        public override IBaseObjectFactory<IColShape> GetColShapeFactory()
        {
            return new ServerColShapeFactory();
        }

        #endregion

        public override void OnStart()
        {
            Alt.Log("Server has been started.");
        }

        public override void OnStop()
        {
            Alt.Log("Server has been stopped.");
        }
    }
}