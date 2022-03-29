git log
git log --oneline
git branch -a -> List all remote branches. 
git branch feature-1 create a new branch 
git checkout feature-1 switch the named branch 
git branch -m feature-x to rename the current branch 
git branch -d <branch> -> This is a “safe” operation in that Git prevents you from deleting the branch if it has unmerged changes.
git branch -D <branch> This is the command to use if you want to permanently throw away all of the commits associated with a particular line of development.
git branch  List all of the branches in your repository. This is synonymous with git branch --list. 
git checkout -b ＜new-branch＞simultaneously creates and checks out ＜new-branch＞
git push --set-upstream origin feature-1