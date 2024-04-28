using Newtonsoft.Json;

public class Datum
{
    [JsonProperty("post_code")]
    public string PostCode { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("street")]
    public string Street { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("only_number")]
    public string OnlyNumber { get; set; }

    [JsonProperty("housing")]
    public string Housing { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("municipality")]
    public string Municipality { get; set; }

    [JsonProperty("post")]
    public string Post { get; set; }

    [JsonProperty("mailbox")]
    public string Mailbox { get; set; }

    [JsonProperty("company")]
    public string Company { get; set; }
}

public class Page
{
    [JsonProperty("current")]
    public int Current { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}

public class Root
{
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("success")]
    public bool Success { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("message_code")]
    public int MessageCode { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("data")]
    public List<Datum> Data { get; set; }

    [JsonProperty("page")]
    public Page Page { get; set; }
}

