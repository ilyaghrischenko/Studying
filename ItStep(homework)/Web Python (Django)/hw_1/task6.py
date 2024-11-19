class Worker:
    def __init__(self, pib, phone_number, email, position, office_number, skype):
        self.pib = pib
        self.phone_number = phone_number
        self.email = email
        self.position = position
        self.office_number = office_number
        self.skype = skype

    def __repr__(self):
        return f"Worker(Name: {self.pib}, Phone: {self.phone_number}, Email: {self.email}, Position: {self.position}, Office: {self.office_number}, Skype: {self.skype})"


class Firm:
    def __init__(self):
        self.workers = {}

    def add_worker(self, worker):
        self.workers[worker.pib] = worker
        print(f"Worker {worker.pib} added.")

    def remove_worker(self, pib):
        if pib in self.workers:
            del self.workers[pib]
            print(f"Worker {pib} removed.")
        else:
            print(f"Worker with name {pib} not found.")

    def find_worker(self, pib):
        return self.workers.get(pib, f"Worker with name {pib} not found.")

    def update_worker(self, pib, **kwargs):
        worker = self.workers.get(pib)
        if worker:
            for key, value in kwargs.items():
                if hasattr(worker, key):
                    setattr(worker, key, value)
            print(f"Worker {pib}'s data updated.")
        else:
            print(f"Worker with name {pib} not found.")

    def list_workers(self):
        if self.workers:
            for worker in self.workers.values():
                print(worker)
        else:
            print("No workers in the database.")


# Example usage
firm = Firm()

# Adding workers
worker1 = Worker("John Doe", "+123456789", "john.doe@company.com", "Manager", "101", "john_skype")
worker2 = Worker("Jane Smith", "+987654321", "jane.smith@company.com", "Engineer", "102", "jane_skype")

firm.add_worker(worker1)
firm.add_worker(worker2)

# Finding a worker
print(firm.find_worker("John Doe"))

# Updating worker data
firm.update_worker("John Doe", phone_number="+111111111", email="john.doe_new@company.com")

# Removing a worker
firm.remove_worker("Jane Smith")

# Listing all workers
firm.list_workers()
