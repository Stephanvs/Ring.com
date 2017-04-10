rm ../src/RingApi/*.cs

autorest -Input ../ring.com.yaml -CodeGenerator CSharp -OutputDirectory ../src/RingApi -Namespace Ring
