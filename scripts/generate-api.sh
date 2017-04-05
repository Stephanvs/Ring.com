rm ../src/RingApi/*.cs

autorest -Input ../ring.com.json -CodeGenerator CSharp -OutputDirectory ../src/RingApi -Namespace Ring
