using TheSaviorIsARobotAPI.DTO;
using TheSaviorIsARobotAPI.Entities;

namespace TheSaviorIsARobotAPI.Mapper
{
    public static class WorldMapper
    {
        public static WorldDTO ToSimpleDTO(this World w)
        {
            return new WorldDTO()
            {
                Name = w.Name,
                Size = w.Size,
                Co2 = w.Co2,
            };
        }
    }
}
