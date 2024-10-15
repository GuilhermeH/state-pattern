using Problem = StatePattern.Sample.Problem;
using Solution = StatePattern.Sample.Solution;

var documentoProblem = new Problem.Document();

documentoProblem.Edit();

documentoProblem.SendToReview();

documentoProblem.Edit();

documentoProblem.Approve();

documentoProblem.Edit();

documentoProblem.Cancel();

Console.WriteLine("-------------");

var documentoSolution = new Solution.Document();

documentoSolution.Edit();

documentoSolution.SendToReview();

documentoSolution.Edit();

documentoSolution.Approve();

documentoSolution.Edit();

documentoSolution.Cancel();