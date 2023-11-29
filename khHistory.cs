// Purpose: the purpose of the history class is to deal with all things history for
// the calculator program, meaning the previous equations, calculations and answers
// caused by the user. It will do nothing else.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/discussion_topics/7606166 | Formatting the program and the comment block.
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0#code-try-4 | Learning how to use the string builder
// https://sl.bing.net/hDHxBfh3QXI | ChatGPT 4 w/ Bing talking about how to format a ToString for the khHistory class.

using System.Text;

    class khHistory {
    private List<double> _khHistoryList;
    private double _khToAdd;

    public khHistory() {}

    public void UpdateHistoryList() {
        _khHistoryList.Add(_khToAdd);
    }

    public override string ToString()
    {
        StringBuilder khStringBuilder = new StringBuilder();
        khStringBuilder.AppendLine("History:");
        khStringBuilder.AppendLine("----------------------------------------");
        khStringBuilder.AppendLine("Equation | Answer");
        for (int i = 0; i < _khHistoryList.Count; i++)
        {
            khStringBuilder.AppendLine($"{i + 1}. {_khHistoryList[i]}");
        }
        khStringBuilder.AppendLine("----------------------------------------");
        return khStringBuilder.ToString();
    }
}
