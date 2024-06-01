

using Demos.PipelinePattern.Models;
using Demos.PipelinePattern.Steps;
using Example.PipelinePattern;
using System;

var pipeline = new Pipeline<OutputData>("MyFirstPipeline");

pipeline.WithStep(new ToUpperStep());
pipeline.WithStep(new TextLengthStep());

var input = new InputData
{
   Text = "Hello World!"
};

var output = await pipeline.StartAsync(input);

Console.WriteLine($"Starting pipeline {pipeline.Name}...");
Console.WriteLine($"Input text: '{input.Text}'");
Console.WriteLine($"Length of text is: {output.Result}");

