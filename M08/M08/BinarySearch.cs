namespace M08
{
    public class BinarySearch
    {
        public static bool DoSearch<T>(IEnumerable<T> collection, T value)
            where T : IComparable<T>
        {
            if (collection.Count() == 0)
                throw new ArgumentNullException("Collection is empty");

            if (collection.Count() == 1)
            {
                if (collection.ElementAt(0).Equals(value))
                    return true;
                else
                    return false;
            }

            return Search(collection, value);
        }

        public static bool Search<T>(IEnumerable<T> collection, T value)
            where T : IComparable<T>
        {
            if (collection.Count() == 0)
                throw new ArgumentNullException("Collection is empty");

            int rightPoint = collection.Count();
            int leftPoint = 0;
            int midPoint = (rightPoint - leftPoint) / 2 + leftPoint;
            bool elementFound = false;

            T expected = collection.ElementAt(midPoint);

            while (!expected.Equals(value) && !(rightPoint - leftPoint == 1))
            {
                var compare = expected.CompareTo(value) > 0 ? expected : value;

                if (compare.Equals(expected))
                {
                    rightPoint = midPoint;
                }
                else
                {
                    leftPoint = midPoint;
                }

                midPoint = (rightPoint - leftPoint) / 2 + leftPoint;
                expected = collection.ElementAt(midPoint);

                if (expected.Equals(value))
                    elementFound = true;
            }

            return elementFound;
        }
    }
}