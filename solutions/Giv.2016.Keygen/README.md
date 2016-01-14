GIV 2016 Keygen Solution
========================

Original post: [link]

-----

Note: This answer isn't entirely mine, I did use SHADOW_UA's dumped .exe.

Short answer
------------

I used a custom build of eazdevirt to devirtualize all protected methods,
found the important one and used it to create a keygen.

Longer answer
-------------

I had to change a few things in eazdevirt to get it working with this file. The
first thing I noticed was the VM's stream type (used to read the encrypted
ManifestResource), which was different to how I'd ever seen it, setting up a
byte array in the constructor and XORing against it when reading data.

After lazily adding support for the stream type, I ran into some deserialization
issues. eazdevirt checks for serialization version V1 and V2 based on how the
stream TypeDef looks. Because of the unexpected stream type, eazdevirt didn't
properly detect V2, so I had to manually force that as well.

At this point I had 6/8 methods devirtualized, with the important method being
one of the 2 that weren't. Looking at the opcodes, about 85% were recognized
(mapped to a delegate method used by the VM). The delegate method that was
breaking things looked almost exactly like the delegate method of Ble, so I
figured it was Ble_Un. After fixing that, I had 8/8 methods devirtualized.

Checking out the fully-devirtualized assembly in dnSpy, I found this snippet
(with a few things renamed):

```cs
string text = string.Empty;
int num = this.NameTextBox.Text.Length - 1;
for (int i = 0; i <= num; i++)
    text += (Strings.Asc(Conversions.ToString(i)) ^ 82).ToString();
if (Operators.CompareString(this.AnswerTextBox.Text, text.ToString(), false) == 0)
    this.Goodboy();
```

After that, it was just creating a simple keygen.

[link]:https://forum.tuts4you.com/topic/37893-keygenme-2016-giv-vb-net/?do=findComment&comment=179933
