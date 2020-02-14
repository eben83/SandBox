using System.Collections.Generic;


namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restarant> GetRestaurantsByName(string name);
        /*
            this will get all the Restarant data
         */

        Restarant GetById(int id);
        /* get the in id for the restarant*/

        Restarant Update(Restarant updatedRestarant);
        /*this is the update property*/

        Restarant Add(Restarant newRestarant);
        Restarant Delete(int id);

        int GetCountOfRestarants();

        int Commit();
        /*this will be used to commit the the server*/

    }
}
