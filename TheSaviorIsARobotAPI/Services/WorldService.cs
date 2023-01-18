using TheSaviorIsARobotAPI.Data;
using TheSaviorIsARobotAPI.DTO;
using TheSaviorIsARobotAPI.Entities;
using TheSaviorIsARobotAPI.Mapper;

namespace TheSaviorIsARobotAPI.Services
{
    public class WorldService
    {
        private readonly TheSaviorIsARobotContext TheSaviorIsARobotContext;

        public WorldService(TheSaviorIsARobotContext TheSaviorIsARobotContext)
        {
            this.TheSaviorIsARobotContext = TheSaviorIsARobotContext;
        }

        public WorldDTO GetOne(int id)
        {

            WorldDTO? world = TheSaviorIsARobotContext.Worlds
                .Where(w => w.Id == id)
                .Select(WorldMapper.ToSimpleDTO)
                .FirstOrDefault();
            if (world is null)
            {
                throw new Exception("Ce monde n'existe pas");
            }
            else
            {
                return world;
            }
        }

        public void UpdateWorld(PollutionDTO pollutionDTO)
        {
            World? world = TheSaviorIsARobotContext.Worlds
                .Where(w => w.Id == pollutionDTO.Id)
                .FirstOrDefault();
            if (world is null)
            {
                throw new Exception("Ce monde n'existe pas");
            }
            else
            {
                world.Co2 -= pollutionDTO.Co2;
                if(world.Co2 < 0) world.Co2 = 0;
                TheSaviorIsARobotContext.Worlds.Update(world);
                TheSaviorIsARobotContext.SaveChanges();
            }
        }
    }
}
