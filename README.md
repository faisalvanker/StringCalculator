
<h1>String Calculator</h1>
<p>1. Create a simple String calculator with a method signature:</p>
<p style="padding-left: 40px;">int Add(string numbers)</p>
<p style="padding-left: 40px;">The method can take up to two numbers, separated by commas, and will return their sum. for example &ldquo;&rdquo; or &ldquo;1&rdquo; or &ldquo;1,2&rdquo; as inputs. (for an empty string it will return 0)</p>
<p>Hints:</p>
<ul>
<li>Start with the simplest test case of an empty string and move to one and two numbers</li>
<li>Remember to solve things as simply as possible so that you force yourself to write tests you did not think about</li>
<li>Remember to refactor after each passing test</li>
</ul>
<p>2. Allow the Add method to handle an unknown amount of numbers</p>
<p>3. Allow the Add method to handle new lines between numbers (instead of commas).</p>
<p style="padding-left: 40px;">the following input is ok: &ldquo;1\n2,3&rdquo; (will equal 6)<br />the following input is NOT ok: &ldquo;1,\n&rdquo; (not need to prove it - just clarifying)</p>
<p>4. Support different delimiters</p>
<p style="padding-left: 40px;">To change a delimiter, the beginning of the string will contain a separate line that looks like this: &ldquo;//[delimiter]\n[numbers&hellip;]&rdquo; for example &ldquo;//;\n1;2&rdquo; should return three where the default delimiter is &lsquo;;&rsquo; <br />The first line is optional. all existing scenarios should still be supported</p>
<p>5. Calling Add with a negative number will throw an exception &ldquo;negatives not allowed&rdquo; - and the negative that was passed. </p>
<p style="padding-left: 40px;">if there are multiple negatives, show all of them in the exception message.</p>
