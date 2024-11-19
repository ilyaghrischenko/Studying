#region classes
class Employer:
    def Print(self):
        print("Employer class")

class President(Employer):
    def Print(self):
        print("President class")

class Manager(Employer):
    def Print(self):
        print("Manager class")

class Worker(Employer):
    def Print(self):
        print("Worker class")
#endregion

em = Employer()
mr = Manager()
wr = Worker()
pr = President()

em.Print()
mr.Print()
wr.Print()
pr.Print()