# Deploying a frontend application to Amazon S3 ( Simple Storage Service)


### Must need


 - AWS Command Line Interface

----------
## How to deploy HTML/CSS or any static file to S3

### 1. Listing buckets

 - The following command lists all buckets.

	

> **$ aws s3 ls**
> 
> ![enter image description here](https://lh3.googleusercontent.com/a-8AQDhkCpoKtIdTN_KyQt4hU3wm6pq3MnjcgQFhnnDhmsgVmDlHOv8XOAYXvmHXzhqrjPaZzMEy=s0)


 - The following command lists all objects and folders (prefixes) in a
   bucket.
   
   

> **$ aws s3 ls s3://*bucket-name*** 
> 
> ![enter image description here](https://lh3.googleusercontent.com/-JL6THVLibFs/WiEiJIgv8II/AAAAAAAAAbA/Ll0Km6UVZ9Y0kghjxCgyldpLBA6LYQW5ACLcBGAs/s0/listing_buckets2.PNG)

**For more command to managing buckets see the link below**


----------


### 2. Managing objects


 - The following example copies an object into a bucket. It grants read
   permissions on the object to everyone (public-read) .
  

> **Permission options:** 
>  - *private*
>  - *public-read*
>  - *public-read-write*
>  - *authenticated-read*
>  - *aws-exec-read*
>  - *bucket-owner-read*
>  - *bucket-owner-full-control*
> 
> **$ aws s3 cp file.txt s3://my-bucket/  *- - acl public-read*** 
> 
> ![enter image description here](https://lh3.googleusercontent.com/-n2Gar9nHT3Q/WiEvoL24uyI/AAAAAAAAAcE/7sqUzYc69o0xR4Kq9Ee7JF11jsLeDkLSwCLcBGAs/s0/upload_file.PNG) 

 


----------


### 3. Delete object from bucket.

To deleting object use ***rm*** command.

> **$ aws s3 rm s3://*my-bucket/path/MySubdirectory/MyFile3.txt*** 
> 
> ![enter image description here](https://lh3.googleusercontent.com/-Rgu2rbYKZz4/WiEwZK_o0CI/AAAAAAAAAcQ/QRcVbJgDeL8t_6gwV9IuGLw7j-WiCQwfwCLcBGAs/s0/delete_from+bucket.PNG) 

 

### 4. Synchronizes the contents

 
The ***sync*** command has the following form. Possible source-target combinations are:

		

>  **1. Local file system to Amazon S3**
>  **2. Amazon S3 to local file system**
>  **3. Amazon S3 to Amazon S3**

 
The following example synchronizes the contents of an Amazon S3  with
the local working directory ***sync*** updates any files that have a
different size or modified time than files with the same name at the
 destination.

 

> **$ aws s3 sync *[source] [target] [--options]*** 
> 
> ![enter image description here](https://lh3.googleusercontent.com/-pwFVJZFPT9c/WiFBs7r1icI/AAAAAAAAAdE/5c61QoAFiiks4UUufAsxJEeXto9nfw3kQCLcBGAs/s0/uploadwithsyncfromlocaltobucket.PNG)


----------


**To get more info from S3 commands visit:** [Amazon S3 commands](http://docs.aws.amazon.com/cli/latest/userguide/using-s3-commands.html)


----------


***Also you can ask for help from the Malachite® team***

*"We care about your applications!"*


