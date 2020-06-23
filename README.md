# Copy Files
Copy files with log information for FF web development
![Copy file form](https://github.com/Bluepearls/CopyFilesRepository/blob/master/CopyFilesWithLogInfo/CopyFiles.jpg)
1.	Solution Name: the web client solution name, the setting is mandatory
2.	Source Path: the source code web folder path, the setting is mandatory
3.	Target Path: the FlexFlow web site’s physical path, the setting is mandatory
4.	Web Client Url: the FlexFlow web url, the setting is optional.
5.	Copy View: if it is ticked, the tool will copy the view files from the Areas folder under the source path to the Areas folder under the Target Path
6.	Copy DLL: If it is ticked, the tool will copy the dll that the name contains the “Solution Name” value from the bin folder under the   source path to the bin folder under the Target Path
7.	Restart Google: if it is ticked, the google chrome will restart after copying, and if the “Web Client Url” is not null, the google chrome will redirect to the “Web Client Url” value.
8.	The tool will compare the two files before copying, if the two files are different, then will overwrite the file, otherwise, it will skip the file. 
