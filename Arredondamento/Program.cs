decimal totalInReal = 326.33M;
var amountParcel = 30;
List<decimal> parcel = new List<decimal>();

decimal parcelValue;

parcelValue = Math.Round((totalInReal / amountParcel), 2);

while (amountParcel > 0)
{
    if (amountParcel != 1)
    {
        totalInReal = totalInReal - parcelValue;
        parcel.Add(parcelValue);
    }
    else
        parcel.Add(totalInReal);

    amountParcel--;
}

var count = 1;
parcel.ForEach(p =>
{
    Console.WriteLine($"Parcel {count}: {p}");
    count++;
});

