using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SuperGalacticFederation.Controls{
public class ThemeManager{
public async Task AutoSetupControls(Control Parent,
Action<Control> Defaults,
Action<Form> IfForm,
Action<Button> IfButton,
Action<Label> IfLabel,
Action<TextBox> IfTextBox,
Action<RichTextBox> IfRichTextBox,
Action<Panel> IfPanel,
Action<SplitContainer> IfSplitContainer,
Action<Splitter> IfSplitter,
Action<ListBox> IfListBox,
Action<ListView> IfListView
) {
Defaults.Invoke(Parent);
var T= Parent.GetType();
if (T== Types.Form) {
IfForm.Invoke(Parent as Form);          
}else if (T== Types.Button) { 
IfButton.Invoke(Parent as Button);             
}else if (T== Types.Label) { 
IfLabel.Invoke(Parent as Label);             
}else if (T== Types.TextBox) { 
IfTextBox.Invoke(Parent as TextBox);             
}else if (T== Types.RichTextBox) { 
IfRichTextBox.Invoke(Parent as RichTextBox);             
}else if (T== Types.Panel) { 
IfPanel.Invoke(Parent as Panel);             
}else if (T== Types.SplitContainer) { 
IfSplitContainer.Invoke(Parent as SplitContainer);             
}else if (T== Types.Splitter) { 
IfSplitter.Invoke(Parent as Splitter);             
}else if (T== Types.ListBox) { 
IfListBox.Invoke(Parent as ListBox);             
}else if (T== Types.ListView) { 
IfListView.Invoke(Parent as ListView);             
}

foreach(Control control in Parent.Controls) {
AutoSetupControls(control,
Defaults,
IfForm,
IfButton,
IfLabel,
IfTextBox,
IfRichTextBox,
IfPanel,
IfSplitContainer,
IfSplitter,
IfListBox,
IfListView
);
}

}



}
}
