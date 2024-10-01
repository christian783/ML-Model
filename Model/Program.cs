using Model;

// Add input data
var sampleData = new Sentiment_model.ModelInput()
{
    Col0 = "This restaurant was disgusting."
};

// Load model and predict output of sample data
var result = Sentiment_model.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");