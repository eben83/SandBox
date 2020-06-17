using System;
using AnimalFarm.Core.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace AnimalFarm.Core.Infrastructure.Serialization
{
    public class AnimalConverter : CustomCreationConverter<Animal>
    {
        private AnimalTypes _animalType;
        private string _animalName;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jAnimal = JToken.ReadFrom(reader);

            var animalTypeProp = jAnimal["Type"];
            var animalNameProp = jAnimal["Type"];

            if (animalTypeProp == null)
                throw new Exception("Can't determine animal without the type");

            if (animalNameProp == null)
                throw new Exception("Can't create an animal without the name");
            
            _animalType = animalTypeProp.ToObject<AnimalTypes>();
            _animalName = animalNameProp.ToObject<string>();
            return base.ReadJson(jAnimal.CreateReader(), objectType, existingValue, serializer);
        }

        public override Animal Create(Type objectType)
        {
            return AnimalFactory.CreateAnimal(_animalType, _animalName);
        }
    }
}